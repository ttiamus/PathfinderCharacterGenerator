using System.Configuration;
using Common.Configuration.EnvironmentConfiguration;

namespace Common.Configuration
{
    public static class ApplicationConfiguration
    {
        public static IApplicationConfiguration GetConfiguration()
        {
            return new ProductionConfiguration();
        }
    }
}
