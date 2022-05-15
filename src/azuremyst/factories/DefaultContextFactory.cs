using Microsoft.EntityFrameworkCore;

namespace azuremyst.factories
{
    sealed class DefaultContextFactory<TContext> : IDbContextFactory<TContext>
        where TContext : DbContext
    {
        readonly IServiceProvider _serviceProvider;

        public DefaultContextFactory(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TContext CreateDbContext()
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException(
                    $"please add an instance of IServiceProvider to the service collection");
            }
            return ActivatorUtilities.CreateInstance<TContext>(_serviceProvider);
        }
    }
}
