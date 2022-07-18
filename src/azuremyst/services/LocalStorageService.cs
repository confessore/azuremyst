using azuremyst.extensions;
using azuremyst.models.abstractions;
using azuremyst.models.enums;
using azuremyst.models.tokens;
using azuremyst.models.users;
using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Reflection;

namespace azuremyst.services
{
    /// <inheritdoc cref="ILocalStorageService" />
    public sealed class LocalStorageService : ILocalStorageService
    {
        readonly ProtectedLocalStorage _protectedLocalStorage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="protectedLocalStorage"></param>
        public LocalStorageService(
            ProtectedLocalStorage protectedLocalStorage)
        {
            _protectedLocalStorage = protectedLocalStorage;
        }

        /// <inheritdoc cref="GetAuthenticationTokenAsync" />
        public async Task<Token> GetAuthenticationTokenAsync()
        {
            var result = await _protectedLocalStorage.GetAsync<AuthenticationToken>(BuildKey(TokenType.Authentication));
            if (result.Success)
            {
                if (result.Value != null)
                    return result.Value;
            }
            return new AuthenticationToken();
        }

        /// <inheritdoc cref="SetAuthenticationTokenAsync(Token)" />
        public async Task SetAuthenticationTokenAsync(Token token) =>
            await _protectedLocalStorage.SetAsync(BuildKey(TokenType.Authentication), token);

        /// <inheritdoc cref="GetRefreshTokenAsync" />
        public async Task<Token> GetRefreshTokenAsync()
        {
            var result = await _protectedLocalStorage.GetAsync<RefreshToken>(BuildKey(TokenType.Refresh));
            if (result.Success)
            {
                if (result.Value != null)
                    return result.Value;
            }
            return new RefreshToken();
        }

        /// <inheritdoc cref="SetRefreshTokenAsync(Token)" />
        public async Task SetRefreshTokenAsync(Token token) =>
            await _protectedLocalStorage.SetAsync(BuildKey(TokenType.Refresh), token);

        /// <inheritdoc cref="GetDefaultUserAsync" />
        public async Task<User> GetDefaultUserAsync()
        {
            var result = await _protectedLocalStorage.GetAsync<DefaultUser>(BuildKey(UserType.Default));
            if (result.Success)
            {
                if (result.Value != null)
                    return result.Value;
            }
            return new DefaultUser();
        }

        /// <inheritdoc cref="SetDefaultUserAsync(User)" />
        public async Task SetDefaultUserAsync(User user) =>
            await _protectedLocalStorage.SetAsync(BuildKey(UserType.Default), user);

        /// <inheritdoc cref="DeleteDefaultUserAsync()" />
        public async Task DeleteDefaultUserAsync() =>
            await _protectedLocalStorage.DeleteAsync(BuildKey(UserType.Default));

        static string BuildKey(Enum value) =>
            $"{Assembly.GetExecutingAssembly().GetName().Name}{value.GetType().Name}{value.GetDescription()}";
    }
}
