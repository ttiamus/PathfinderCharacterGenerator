using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Core.V2.Shared;

namespace Core.V2.Items
{
    public class ItemRepository : AbstractMongoRepository
    {
        public ItemRepository(IApplicationConfiguration config) : base(config.PathfinderConnectionString, config.PathfinderDatabaseName, "Items")
        {
        }
    }
}
