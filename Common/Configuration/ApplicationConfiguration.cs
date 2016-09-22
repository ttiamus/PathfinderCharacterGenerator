using Common.Configuration.EnvironmentConfiguration;

namespace Common.Configuration
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public IEnvironmentConfiguration GetConfiguration()
        {
            return new ProductionConfiguration();
        }
    }
}
