using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Interfaces;
using Common.Results;
using Core.Items.InsertItem;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.Items.UpdateItem
{
    public class UpdateItemRepository : ICommandRepository<UpdateItemRequest>
    {
        private readonly IMongoCollection<Item> collection;

        public UpdateItemRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<CommandResult> SaveChanges(UpdateItemRequest request)
        {
            var item = request.ToItem();
            await collection.ReplaceOneAsync(x => x.Id == item.Id, item);
            return await Task.Run(() => new CommandResult());
        }
    }
}
