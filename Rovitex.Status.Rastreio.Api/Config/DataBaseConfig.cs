using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Rovitex.Status.Rastreio.Api.Config
{
    public static class DataBaseConfig
    {
        public static IServiceCollection AddDataBaseConfig(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<IDbConnection, OracleConnection>(sp =>
            { 
                return new OracleConnection(config.GetConnectionString("VESTIS01"));
            });

            return services;
        }
    }
}
