
using System.Configuration;

namespace Common.Configuration.EnvironmentConfiguration
{
    public class ProductionConfiguration : IEnvironmentConfiguration
    {
        public string MongoUserName => ConfigurationManager.AppSettings["MongoUsername"];
        public string MongoPassword => ConfigurationManager.AppSettings["MongoPassword"];
        public string PathfinderConnectionString => string.Format(ConfigurationManager.AppSettings["PathfinderConnectionString"], MongoUserName, MongoPassword);
        public string PathfinderDatabaseName => "pathfinder";
    }
}
