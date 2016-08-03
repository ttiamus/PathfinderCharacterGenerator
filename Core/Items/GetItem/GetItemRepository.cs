using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Interfaces;
using Common.Results;
using Core.Items.GetItems;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.Items.GetItem
{
    public class GetItemRepository : IQueryRepository<GetItemRequest, GetItemResponse>
    {
        private readonly IMongoCollection<Item> collection;

        public GetItemRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<Result<GetItemResponse>> SaveChanges(GetItemRequest request)
        {
            var result = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            var item = result.ToItemResponse();
            return await Task.Run(() => new Result<GetItemResponse>(item));
        }
    }
}
