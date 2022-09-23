using Microsoft.Extensions.Configuration;

namespace GAR_FIAS_WorkerService.Helpers
{
    static class ConfigurationHelper
    {
        public static string GetSectionValue(string configKeyName)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            IConfigurationSection section = config.GetSection(configKeyName);

            return section.Value;
        }
    }
}
