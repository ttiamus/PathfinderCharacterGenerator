using Common.Configuration.EnvironmentConfiguration;
using Core.V2.ItemTypes.Models;
using Core.V2.Shared;

namespace Core.V2.ItemTypes
{
    public class ItemTypeRepository : AbstractMongoRepository<ItemType>
    {
        public ItemTypeRepository(IEnvironmentConfiguration config)
            : base(config.PathfinderConnectionString, config.PathfinderDatabaseName, "ItemTypes")
        {
        }
    }
}