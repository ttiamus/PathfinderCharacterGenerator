using Common.Configuration.EnvironmentConfiguration;

namespace Common.Configuration
{
    public interface IApplicationConfiguration
    {
        IEnvironmentConfiguration GetConfiguration();
    }
}
