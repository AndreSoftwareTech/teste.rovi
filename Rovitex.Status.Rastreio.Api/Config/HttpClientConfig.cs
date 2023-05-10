using System.Net.Http.Headers;

namespace Rovitex.Status.Rastreio.Api.Config
{
    public static class HttpClientConfig
    {
        public static IServiceCollection ConfigureHttpClientes(this IServiceCollection services, IConfiguration config)
        {
            services.AddHttpClient("LogisticaApi", client =>
            {
                client.BaseAddress = new Uri(config.GetSection("LogisticaApiConfig").GetValue<string>("Url"));
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-tenant", config.GetSection("LogisticaApiConfig").GetValue<string>("Tenant"));
            });

            services.AddHttpClient("AuthApi", client =>
            {
                client.BaseAddress = new Uri(config.GetSection("AuthApiConfig").GetValue<string>("Url"));
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-tenant", config.GetSection("AuthApiConfig").GetValue<string>("Tenant"));
            });

            return services;
        }
    }
}
