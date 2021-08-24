using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Modules.MyModule2.Services;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ModularMonolith.Api")]
namespace ModularMonolith.Modules.MyModule2
{
    internal static class Extensions
    {
        public static IServiceCollection AddModule1(this IServiceCollection services)
        {
            services.AddTransient<IModule2Service, Module2Service>();
            return services;
        }
    }
}