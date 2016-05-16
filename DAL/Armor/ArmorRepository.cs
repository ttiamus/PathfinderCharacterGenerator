using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Armor;
using MongoDB.Driver;

namespace DAL.Armor
{
    public class ArmorRepository : IArmorRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Armor> collection; 

        public ArmorRepository()
        {
            IMongoDatabase database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Armor>("Armors");
        }

        public async Task<IEnumerable<Core.Armor.Armor>> GetArmors()
        {
            var armors = await collection.Find(x => true).ToListAsync();
            return armors.Select(armor => armor.ToCore());
        }

        public async Task<Core.Armor.Armor> GetArmor(string id)
        {
            var armor = await collection.Find(x=> x.Id.ToLower().Equals(id.ToLower())).FirstOrDefaultAsync();
            return armor.ToCore();
        }

        public async Task InsertArmor(Core.Armor.Armor armor)
        {
            await collection.InsertOneAsync(armor.ToDal());
        }

        public async Task UpdateArmor(Armor armor)
        {
            await collection.ReplaceOneAsync(x => x.Id.ToLower().Equals(armor.Id.ToLower()), armor);
        }

        public async Task DeleteArmor(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.ToLower().Equals(id.ToLower()));
        }
    }
}
