using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Modules.MyModule1.Services;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ModularMonolith.Api")]
namespace ModularMonolith.Modules.MyModule1
{
    internal static class Extensions
    {
        public static IServiceCollection AddModule2(this IServiceCollection services)
        {
            services.AddTransient<IModule1Service, Module1Service>();
            return services;
        }
    }
}
