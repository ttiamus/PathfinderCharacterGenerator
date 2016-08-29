using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Configuration.EnvironmentConfiguration
{
    public class ProductionConfiguration : IApplicationConfiguration
    {
        public string MongoUserName => ConfigurationManager.AppSettings["MongoUsername"];
        public string MongoPassword => ConfigurationManager.AppSettings["MongoPassword"];
        public string PathfinderConnectionString => string.Format(ConfigurationManager.AppSettings["PathfinderConnectionString"], MongoUserName, MongoPassword);
        public string CharacterConnectionString => string.Format(ConfigurationManager.AppSettings["CharacterConnectionString"], MongoUserName, MongoPassword);
        public string PathfinderDatabaseName => "Pathfinder";
    }
}
