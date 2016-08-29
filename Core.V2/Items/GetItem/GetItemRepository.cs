using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.Items.Models.Responses;

namespace Core.V2.Items.GetItem
{
    public class GetItemRepository : IQueryRepository<GetItemRequest, ItemResponse>
    {
        public Task<ItemResponse> Execute(GetItemRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}