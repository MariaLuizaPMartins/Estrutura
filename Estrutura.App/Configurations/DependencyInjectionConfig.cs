using Estrutura.Business.Services;
using Estrutura.Business.Services.Interfaces;
using Estrutura.Data.Context;
using Estrutura.Data.Repositories;
using Estrutura.Data.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Estrutura.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();

            #region Services
            services.AddScoped<INotificador, NotificadorService>();
            services.AddScoped<ICorService, CorService>();
            #endregion

            #region Repository
            services.AddScoped(typeof(IRepositoryActions<>), typeof(RepositoryActions<>));
            services.AddScoped<ICorRepository, CorRepository>();
            #endregion

            return services;
        }
    }
}
