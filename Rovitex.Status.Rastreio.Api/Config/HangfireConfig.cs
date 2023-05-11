using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

using Hangfire;
using Hangfire.MemoryStorage;
using Rovitex.Status.Rastreio.Domain.Interfaces;

namespace Rovitex.Status.Rastreio.Api.Config
{
    public static class HangfireConfig
    {
        public static IServiceCollection AddHangfireConfig(this IServiceCollection services, IConfiguration configuration, bool isDevelopment)
        {
            services.AddHangfire(config =>
            {
                if (isDevelopment || true)
                    config.UseStorage(new MemoryStorage());

                else
                    config.UseSqlServerStorage(configuration.GetConnectionString("SqlServerHangfire"));

            });

            services.AddHangfireServer();

            return services;
        }

        public static IApplicationBuilder UseHangfireConfig(this IApplicationBuilder app)
        {
            
            app.UseHangfireDashboard();
            app.InitializeHangfireJobs();

            return app;
        }

        public static IApplicationBuilder InitializeHangfireJobs(this IApplicationBuilder app)
        {
            RecurringJob.AddOrUpdate<IStatusRastreioService>("Serviço de Status Rota", service => service.Processar(), "0 * * * *", TimeZoneInfo.Local);

            return app;
        }
    }
}

