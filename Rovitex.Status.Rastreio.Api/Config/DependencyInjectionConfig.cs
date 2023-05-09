using Hangfire;
using Rovitex.Status.Rastreio.Domain.Config;
using Rovitex.Status.Rastreio.Domain.Enums;
using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Api.Services;
using Rovitex.Status.Rastreio.Infrastructure.Repositorios;
using System.Data;

namespace Rovitex.Status.Rastreio.Api.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IStatusRastreio, StatusRastreio>();
            services.AddScoped<IStatusRota, StatusRota>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
