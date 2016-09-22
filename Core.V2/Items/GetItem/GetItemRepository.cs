using System.Threading.Tasks;
using Common.Configuration;
using Common.Interfaces;
using Core.V2.Items.Models.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.V2.Items.GetItem
{
    public class GetItemRepository : ItemRepository, IQueryRepository<GetItemRequest, ItemResponse>
    {
        public GetItemRepository(IApplicationConfiguration config) : base(config.GetConfiguration())
        {

        }

        public async Task<ItemResponse> Execute(GetItemRequest request)
        {
            var item = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            return item.ToItemReponse();
        }
    }
}