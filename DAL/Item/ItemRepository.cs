using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Item;
using MongoDB.Driver;

namespace DAL.Item
{
    public class ItemRepository : IItemRepository
    {
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Item> Collection;

        public ItemRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Item>("CollectionName");
        }

        public async Task<IEnumerable<Core.Item.Item>> GetItems()
        {
            var Items = await Collection.Find(x => true).ToListAsync();
            return Items.Select(Item => Item.ToCore());
        }

        public async Task<Core.Item.Item> GetItem(int id)
        {
            var Item = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Item.ToCore();
        }

        public async Task InsertItem(Core.Item.Item Item)
        {
            await Collection.InsertOneAsync(Item.ToDal());
        }

        public async Task UpdateItem(Item Item)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Item.Id, Item);
        }

        public async Task DeleteItem(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
