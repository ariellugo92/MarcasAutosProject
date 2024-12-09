using MarcasAuto.Application.Interfaces;
using MarcasAuto.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarcasAuto.Application.IOC
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IMarcasAutoService, MarcasAutoService>();

            return services;
        }
    }
}
