using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Caledonia;
using R5T.Caledonia.Default;
using R5T.Dacia;
using R5T.Norsica.Configuration;
using R5T.Norsica.Configuration.Sardinia;
using R5T.Norsica.Default;


namespace R5T.Norsica.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDotnetExecutableFilePathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddDotnetExecutableFilePathProvider(this IServiceCollection services)
        {
            services.AddConfigurationBasedDotnetExecutableFilePathProvider(
                services.AddDotnetConfigurationAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDotnetExecutableFilePathProvider"/> service.
        /// </summary>
        public static ServiceAction<IDotnetExecutableFilePathProvider> AddDotnetExecutableFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDotnetExecutableFilePathProvider>(() => services.AddDotnetExecutableFilePathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IDotnetOperator"/> service.
        /// </summary>
        public static IServiceCollection AddDotnetOperator(this IServiceCollection services)
        {
            services.AddDefaultDotnetOperator(
                services.AddDefaultCommandLineInvocationOperatorAction(),
                services.AddDotnetExecutableFilePathProviderAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDotnetOperator"/> service.
        /// </summary>
        public static ServiceAction<IDotnetOperator> AddDotnetOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDotnetOperator>(() => services.AddDotnetOperator());
            return serviceAction;
        }
    }
}
