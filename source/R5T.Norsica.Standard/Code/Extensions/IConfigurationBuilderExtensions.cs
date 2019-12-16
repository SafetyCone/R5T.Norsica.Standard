using System;

using Microsoft.Extensions.Configuration;

using R5T.Norsica.Configuration.Suebia;


namespace R5T.Norsica.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddDotnetConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddDotnetConfigurationJsonFile(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
