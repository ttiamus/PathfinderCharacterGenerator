using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Interfaces;
using Common.Results;
using MongoDB.Driver;

namespace Core.Items.GetItems
{
    public class GetItemsRepository : IQueryRepository<GetItemsRequest, IEnumerable<GetItemsResponse>>
    {
        private readonly IMongoCollection<Items.Item> collection;

        public GetItemsRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Item>("Items");
        }

        public async Task<QueryResult<IEnumerable<GetItemsResponse>>> SaveChanges(GetItemsRequest request)
        {
            var result = await collection.Find(x => true).ToListAsync();
            var items = result.Select(item => item.ToItemsResponse());
            return await Task.Run(() => new QueryResult<IEnumerable<GetItemsResponse>>(items));
        }
    }
}
