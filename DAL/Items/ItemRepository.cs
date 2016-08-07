using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Results;
using Core.Items;
using Core.Items.Requests;
using Core.Items.Resposnes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Items
{
    public class ItemRepository : IItemRepository
    {
        private readonly IMongoCollection<Item> collection;

        public ItemRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<Result<IEnumerable<ItemResponse>>> GetItems()
        {
            var result = await collection.Find(x => true).ToListAsync();
            var items = result.Select(request => request.ToItemResponse());
            return new Result<IEnumerable<ItemResponse>>(items);
        }

        public async Task<Result<ItemResponse>> GetItem(GetItemRequest request)
        {
            var item = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            return new Result<ItemResponse>(item.ToItemResponse());
        }

        public async Task<Result> InsertItem(InsertItemRequest request)
        {
            await collection.InsertOneAsync(request.ToItem());
            return new Result();
        }

        public async Task<Result> UpdateItem(UpdateItemRequest request)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)), request.ToItem());
            return new Result();
        }

        public async Task<Result> DeleteItem(DeleteItemRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
            return new Result();
        }
    }
}
