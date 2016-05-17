using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Item;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Item
{
    public class ItemRepository : IItemRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Item> collection;

        public ItemRepository()
        {
            var database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<IEnumerable<Core.Item.Item>> GetItems()
        {
            var items = await collection.Find(x => true).ToListAsync();
            return items.Select(item => item.ToCore());
        }

        public async Task<Core.Item.Item> GetItem(string id)
        {
            var item = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return item.ToCore();
        }

        public async Task InsertItem(Core.Item.Item item)
        {
            await collection.InsertOneAsync(item.ToDal());
        }

        public async Task UpdateItem(Core.Item.Item item)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(item.Id)), item.ToDal());
        }

        public async Task DeleteItem(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
