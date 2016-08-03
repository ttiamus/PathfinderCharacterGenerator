using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Interfaces;
using Common.Results;
using MongoDB.Driver;

namespace Core.Items.InsertItem
{
    public class InsertItemRepository : ICommandRepository<InsertItemRequest>
    {
        private readonly IMongoCollection<InsertItemRequest> collection;

        public InsertItemRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<InsertItemRequest>("Items");
        }

        public async Task<Result> SaveChanges(InsertItemRequest item)
        {
            await collection.InsertOneAsync(item);
            return new Result();
        }
    }
}
