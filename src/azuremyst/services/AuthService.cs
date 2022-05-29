using azuremyst.contexts;
using azuremyst.models.abstractions;
using azuremyst.models.enums;
using azuremyst.models.tokens;
using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace azuremyst.services
{
    /// <inheritdoc cref="IAuthService" />
    sealed class AuthService : IAuthService
    {
        readonly IDbContextFactory<DefaultDbContext> _defaultDbContextFactory;
        readonly SignInManager<User> _signInManager;
        readonly UserManager<User> _userManager;
        readonly ILocalStorageService _localStorageService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultDbContextFactory"></param>
        /// <param name="signInManager"></param>
        /// <param name="userManager"></param>
        /// <param name="localStorageService"></param>
        public AuthService(
            IDbContextFactory<DefaultDbContext> defaultDbContextFactory,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            ILocalStorageService localStorageService)
        {
            _defaultDbContextFactory = defaultDbContextFactory;
            _signInManager = signInManager;
            _userManager = userManager;
            _localStorageService = localStorageService;
        }

        /// <inheritdoc cref="IAuthService.BuildAuthenticationStateAsync(string)" />
        public async Task<AuthenticationState> BuildAuthenticationStateAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var principal = await _signInManager.CreateUserPrincipalAsync(user);
                var identity = new ClaimsIdentity(principal.Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                principal = new ClaimsPrincipal(identity);
                return new AuthenticationState(principal);
            }
            return new AuthenticationState(new ClaimsPrincipal());
        }

        /// <inheritdoc cref="IAuthService.BuildAuthenticationStateAsync(User)" />
        public async Task<AuthenticationState> BuildAuthenticationStateAsync(User user)
        {
            var principal = await _signInManager.CreateUserPrincipalAsync(user);
            var identity = new ClaimsIdentity(principal.Claims, CookieAuthenticationDefaults.AuthenticationScheme);
            principal = new ClaimsPrincipal(identity);
            return new AuthenticationState(principal);
        }

        async Task<Token> GetAuthenticationTokenAsync(User user)
        {
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null && userContext.Tokens != null)
                {
                    var token = userContext.Tokens.FirstOrDefault(x => x.TokenType == TokenType.Authentication);
                    if (token != null)
                        return token;
                }
            }
            return new AuthenticationToken();
        }

        async Task<Token> GetRefreshTokenAsync(User user)
        {
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null && userContext.Tokens != null)
                {
                    var token = userContext.Tokens.FirstOrDefault(x => x.TokenType == TokenType.Refresh);
                    if (token != null)
                        return token;
                }
            }
            return new RefreshToken();
        }

        async Task<Token> GetConfirmationTokenAsync(User user)
        {
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null && userContext.Tokens != null)
                {
                    var token = userContext.Tokens.FirstOrDefault(x => x.TokenType == TokenType.Confirmation);
                    if (token != null)
                        return token;
                }
            }
            return new ConfirmationToken();
        }

        /// <inheritdoc cref="IAuthService.PasswordAuthenticateAsync(string, string)" />
        public async Task<bool> PasswordAuthenticateAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                await _localStorageService.DeleteDefaultUserAsync();
                if (await _userManager.CheckPasswordAsync(user, password))
                {
                    var authenticationToken = await GetAuthenticationTokenAsync(user);
                    if (authenticationToken != null)
                    {
                        if (await TokenExpiresSoonAsync(authenticationToken))
                            await UpsertTokenAsync(user, GenerateAuthenticationToken(user));
                    }
                    else
                        await UpsertTokenAsync(user, GenerateAuthenticationToken(user));
                    var refreshToken = await GetRefreshTokenAsync(user);
                    if (refreshToken != null)
                    {
                        if (await TokenExpiresSoonAsync(refreshToken))
                            await UpsertTokenAsync(user, GenerateRefreshToken(user));
                    }
                    else
                        await UpsertTokenAsync(user, GenerateRefreshToken(user));
                    using var context = await _defaultDbContextFactory.CreateDbContextAsync();
                    if (context.Users != null)
                    {
                        var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                        if (userContext != null)
                        {
                            await _localStorageService.SetDefaultUserAsync(userContext);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <inheritdoc cref="IAuthService.IsTokenExpiredAsync(Token)" />
        public Task<bool> IsTokenExpiredAsync(Token token)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var expired = now > token.Expiration;
            return Task.FromResult(expired);
        }

        /// <inheritdoc cref="IAuthService.IsTokenInspiredAsync(Token)" />
        public Task<bool> IsTokenInspiredAsync(Token token)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var valid = now < token.Expiration;
            return Task.FromResult(valid);
        }

        /// <inheritdoc cref="IAuthService.IsTokenValidAsync(Token)" />
        public async Task<bool> IsTokenValidAsync(Token token)
        {
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Tokens != null)
            {
                var tokenContext = await context.Tokens.FirstOrDefaultAsync(x => x.Id == token.Id);
                if (tokenContext != null)
                {
                    if (token.Hash == tokenContext.Hash)
                        return true;
                }
            }
            return false;
        }

        /// <inheritdoc cref="IAuthService.RenewAuthenticationTokenAsync(User)" />
        public async Task RenewAuthenticationTokenAsync(User user)
        {
            await UpsertTokenAsync(user, GenerateAuthenticationToken(user));
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null)
                    await _localStorageService.SetDefaultUserAsync(userContext);
            }
        }

        /// <inheritdoc cref="IAuthService.RenewRefreshTokenAsync(User)" />
        public async Task RenewRefreshTokenAsync(User user)
        {
            await UpsertTokenAsync(user, GenerateRefreshToken(user));
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null)
                    await _localStorageService.SetDefaultUserAsync(userContext);
            }
        }

        /// <inheritdoc cref="IAuthService.TokenAuthenticateAsync(Token, Token)" />
        public async Task<bool> TokenAuthenticateAsync(User user)
        {
            if (user.Tokens != null)
            {
                var authenticationToken = user.Tokens.FirstOrDefault(x => x.TokenType == TokenType.Authentication);
                var refreshToken = user.Tokens.FirstOrDefault(x => x.TokenType == TokenType.Refresh);
                if (authenticationToken != null && refreshToken != null)
                {
                    if (await IsTokenInspiredAsync(authenticationToken))
                    {
                        var valid = await IsTokenValidAsync(authenticationToken);
                        if (await TokenExpiresSoonAsync(authenticationToken))
                            await RenewAuthenticationTokenAsync(user);
                        return valid;
                    }
                    else if (await IsTokenInspiredAsync(refreshToken))
                    {
                        var valid = await IsTokenValidAsync(refreshToken);
                        if (valid)
                            await RenewAuthenticationTokenAsync(user);
                        if (await TokenExpiresSoonAsync(refreshToken))
                            await RenewRefreshTokenAsync(user);
                        return valid;
                    }
                }
            }
            return false;
        }

        /// <inheritdoc cref="IAuthService.TokenExpiresSoonAsync(Token)" />
        public Task<bool> TokenExpiresSoonAsync(Token token)
        {
            var then = DateTimeOffset.UtcNow.AddHours(2.5f).ToUnixTimeSeconds();
            var expired = then > token.Expiration;
            return Task.FromResult(expired);
        }

        async Task UpsertTokenAsync(
            User user,
            Token token)
        {
            using var context = await _defaultDbContextFactory.CreateDbContextAsync();
            if (context.Users != null)
            {
                var userContext = await context.Users.Include(x => x.Tokens).FirstOrDefaultAsync(x => x.Id == user.Id);
                if (userContext != null && userContext.Tokens != null)
                {
                    var existingToken = userContext.Tokens.FirstOrDefault(x => x.TokenType == token.TokenType);
                    if (existingToken != null)
                    {
                        if (context.Tokens != null)
                            context.Tokens.Remove(existingToken);
                    }
                    userContext.Tokens.Add(token);
                    await context.SaveChangesAsync();
                }
            }
        }

        public static Token GenerateAuthenticationToken(User user) =>
            new AuthenticationToken()
            {
                TokenType = TokenType.Authentication,
                Hash = Guid.NewGuid().ToString(),
                Expiration = DateTimeOffset.UtcNow.AddDays(1).ToUnixTimeSeconds(),
                UserId = user.Id
            };

        public static Token GenerateRefreshToken(User user) =>
            new RefreshToken()
            {
                TokenType = TokenType.Refresh,
                Hash = Guid.NewGuid().ToString(),
                Expiration = DateTimeOffset.UtcNow.AddDays(7).ToUnixTimeSeconds(),
                UserId = user.Id
            };

        public static Token GenerateConfirmationToken(User user) =>
            new ConfirmationToken()
            {
                TokenType = TokenType.Confirmation,
                Hash = Guid.NewGuid().ToString(),
                Expiration = DateTimeOffset.UtcNow.AddDays(1).ToUnixTimeSeconds(),
                UserId = user.Id
            };

        public static Token GenerateDefaultToken(TokenType tokenType, int days) =>
            new DefaultToken()
            {
                TokenType = tokenType,
                Hash = Guid.NewGuid().ToString(),
                Expiration = DateTimeOffset.UtcNow.AddDays(days).ToUnixTimeSeconds()
            };
    }
}
