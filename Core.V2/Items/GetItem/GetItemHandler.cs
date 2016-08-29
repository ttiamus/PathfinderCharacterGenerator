using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.Items.Models.Responses;

namespace Core.V2.Items.GetItem
{
    public class GetItemHandler : IQueryHandler<GetItemRequest, ItemResponse>
    {
        private readonly IQueryRepository<GetItemRequest, ItemResponse> repo;

        public GetItemHandler(IQueryRepository<GetItemRequest, ItemResponse> repo)
        {
            this.repo = repo;
        }

        public void Validate(GetItemRequest request)
        {
            
        }

        public async Task<ItemResponse> Execute(GetItemRequest request)
        {
            Validate(request);
            return await repo.Execute(request);
        }
    }
}