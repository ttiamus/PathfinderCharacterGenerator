using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Configuration;
using Common.Interfaces;
using Core.V2.Items.Models.Responses;
using MongoDB.Driver;

namespace Core.V2.Items.GetAllItems
{
    public class GetAllItemsRepository : ItemRepository, IQueryRepository<GetAllItemsRequest, IEnumerable<ItemResponse>>
    {
        private readonly IApplicationConfiguration config;

        public GetAllItemsRepository(IApplicationConfiguration config) : base(config)
        {
            this.config = config;
        }

        public async Task<IEnumerable<ItemResponse>> Execute(GetAllItemsRequest request)
        {
            var items = await collection.Find(x => true).ToListAsync();
            return items.Select(item => item.ToItemReponse());
        }
    }
}