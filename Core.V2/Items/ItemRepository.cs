using Common.Configuration.EnvironmentConfiguration;
using Core.V2.Items.Models.Data;
using Core.V2.Shared;

namespace Core.V2.Items
{
    public class ItemRepository : AbstractMongoRepository<Item>
    {
        public ItemRepository(IEnvironmentConfiguration config) : base(config.PathfinderConnectionString, config.PathfinderDatabaseName, "Items") { }
    }
}
