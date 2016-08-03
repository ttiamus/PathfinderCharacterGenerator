using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Interfaces;
using Common.Results;
using Core.Items.UpdateItem;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.Items.DeleteItem
{
    public class DeleteItemRepository : ICommandRepository<DeleteItemRequest>
    {
        private readonly IMongoCollection<Item> collection;

        public DeleteItemRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<Result> SaveChanges(DeleteItemRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
            return await Task.Run(() => new Result());
        }
    }
}
