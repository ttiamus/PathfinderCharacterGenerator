using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ApplicationConfiguration
    {
        private static string MongoUserName => ConfigurationManager.AppSettings["MongoUsername"];

        private static string MongoPassword => ConfigurationManager.AppSettings["MongoPassword"];

        public static string PathfinderConnectionString => string.Format(ConfigurationManager.AppSettings["PathfinderConnectionString"], MongoUserName, MongoPassword);

        public static string CharacterConnectionString => string.Format(ConfigurationManager.AppSettings["CharacterConnectionString"], MongoUserName, MongoPassword);
    }
}
