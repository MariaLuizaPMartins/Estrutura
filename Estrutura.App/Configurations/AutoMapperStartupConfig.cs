using AutoMapper;
using Estrutura.Business.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Estrutura.App.Configurations
{
    public static class AutoMapperStartupConfig
    {
        public static IServiceCollection AutoMapperServiceConfig(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CorMapper());
            });

            services.AddSingleton(mappingConfig.CreateMapper());

            return services;
        }
    }
}
