using Microsoft.Extensions.Configuration;

namespace MyProject.DataAccess
{
    public static class ConfigurationProvider
    {
        public static IConfigurationRoot GetConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            return configurationBuilder;
        }
    }
}
