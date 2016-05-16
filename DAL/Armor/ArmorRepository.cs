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
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Armor> Collection; 

        public ArmorRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Armor>("CollectionName");
        }

        public async Task<IEnumerable<Core.Armor.Armor>> GetArmors()
        {
            var armors = await Collection.Find(x => true).ToListAsync();
            return armors.Select(armor => armor.ToCore());
        }

        public async Task<Core.Armor.Armor> GetArmor(int id)
        {
            var armor = await Collection.Find(x=> x.Id == id).FirstOrDefaultAsync();
            return armor.ToCore();
        }

        public async Task InsertArmor(Core.Armor.Armor armor)
        {
            await Collection.InsertOneAsync(armor.ToDal());
        }

        public async Task UpdateArmor(Armor armor)
        {
            await Collection.ReplaceOneAsync(x => x.Id == armor.Id, armor);
        }

        public async Task DeleteArmor(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
