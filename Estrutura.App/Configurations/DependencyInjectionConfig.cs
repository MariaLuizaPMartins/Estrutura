using Estrutura.Business.Services.CorService;
using Estrutura.Data.Context;
using Estrutura.Data.Repositories.CorRepository;
using Estrutura.Shared.NotificacaoWs;
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
            services.AddScoped<ICorRepository, CorRepository>();
            #endregion

            return services;
        }
    }
}
