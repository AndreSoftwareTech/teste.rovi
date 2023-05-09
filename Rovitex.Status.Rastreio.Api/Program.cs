
using Rovitex.Status.Rastreio.Api.Config;
using Rovitex.Status.Rastreio.Api.Services;
using System.Configuration;

namespace Rovitex.Status.Rastreio.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDependencyInjectionConfig(builder.Configuration);
            builder.Services.AddHangfireConfig(builder.Configuration, builder.Environment.IsDevelopment());
            builder.Services.AddDataBaseConfig(builder.Configuration);


            var app = builder.Build();

            app.UseHangfireConfig();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}