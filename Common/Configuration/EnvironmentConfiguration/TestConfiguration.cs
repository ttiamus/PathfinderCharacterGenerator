using System.Configuration;

namespace Common.Configuration.EnvironmentConfiguration
{
    public class TestConfiguration : IApplicationConfiguration
    {
        public string MongoUserName => ConfigurationManager.AppSettings["MongoUsername"];
        public string MongoPassword => ConfigurationManager.AppSettings["MongoPassword"];
        public string PathfinderConnectionString => string.Format(ConfigurationManager.AppSettings["PathfinderConnectionString"], MongoUserName, MongoPassword);
        public string CharacterConnectionString => string.Format(ConfigurationManager.AppSettings["CharacterConnectionString"], MongoUserName, MongoPassword);
        public string PathfinderDatabaseName => "PathfinderTest";
    }
}