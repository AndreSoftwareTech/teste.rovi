using Rovitex.Status.Rastreio.Api.Services;
using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Domain.Models.AuthApi;
using Rovitex.Status.Rastreio.Infrastructure.Repositorios;

namespace Rovitex.Status.Rastreio.Api.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<ILogisticaApiRepository, LogisticaApiRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient(serviceProvider =>
            {
                return new AutenticacaoModel()
                {
                    Username = config.GetSection("AuthApiConfig").GetValue<string>("Usuario"),
                    Password = config.GetSection("AuthApiConfig").GetValue<string>("Senha"),
                };
            });

            return services;
        }
    }
}
