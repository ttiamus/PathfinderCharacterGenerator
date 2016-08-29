using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Core.Armors;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Armors
{
    public class ArmorRepository : IArmorRepository
    {
        private readonly IMongoCollection<Armor> collection;
        private readonly IApplicationConfiguration config;

        public ArmorRepository(IApplicationConfiguration config)
        {
            this.config = config;

            var client = new MongoClient(config.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Armor>("Armors");
        }

        public async Task<IEnumerable<Core.Armors.Armor>> GetArmors()
        {
            var armors = await collection.Find(x => true).ToListAsync();
            return armors.Select(armor => armor.ToCore());
        }

        public async Task<Core.Armors.Armor> GetArmor(string id)
        {
            var armor = await collection.Find(x=> x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return armor.ToCore();
        }

        public async Task InsertArmor(Core.Armors.Armor armor)
        {
            await collection.InsertOneAsync(armor.ToDal());
        }

        public async Task UpdateArmor(Core.Armors.Armor armor)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(armor.Id)), armor.ToDal());
        }

        public async Task DeleteArmor(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
