using azuremyst.models.abstractions;

namespace azuremyst.services.interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILocalStorageService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Token> GetAuthenticationTokenAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task SetAuthenticationTokenAsync(Token token);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Token> GetRefreshTokenAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task SetRefreshTokenAsync(Token token);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<User> GetDefaultUserAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task SetDefaultUserAsync(User user);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task DeleteDefaultUserAsync();
    }
}
