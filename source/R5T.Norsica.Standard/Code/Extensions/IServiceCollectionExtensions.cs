using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Caledonia;
using R5T.Caledonia.Default;
using R5T.Norsica.Default;
using R5T.Norsica.Configuration;
using R5T.Norsica.Configuration.Sardinia;


namespace R5T.Norsica.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDotnetOperator(this IServiceCollection services)
        {
            services
                .AddSingleton<IDotnetOperator, DotnetOperator>()
                .AddSingleton<IDotnetExecutableFilePathProvider, ConfigurationBasedDotnetExecutableFilePathProvider>()
                .AddDotnetConfiguration()
                .AddSingleton<ICommandLineInvocationOperator, DefaultCommandLineInvocationOperator>()
                ;

            return services;
        }
    }
}
