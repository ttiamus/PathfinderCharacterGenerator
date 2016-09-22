using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.Items.Models.Responses;
using Core.V2.ItemTypes.Models;

namespace Core.V2.Items.GetAllItems
{
    public class GetAllItemsHandler : IQueryHandler<GetAllItemsRequest, List<ItemResponse>>
    {
        private readonly IQueryRepository<GetAllItemsRequest, IEnumerable<ItemResponse>> repo;

        public GetAllItemsHandler(IQueryRepository<GetAllItemsRequest, IEnumerable<ItemResponse>> repo)
        {
            this.repo = repo;
        }

        public void Validate(GetAllItemsRequest request)
        {
            
        }

        public async Task<List<ItemResponse>> Execute(GetAllItemsRequest request)
        {
            Validate(request);

            var items = await repo.Execute(request);
            var itemList = items.ToList();

            foreach (var item in itemList)
            {
                item.ItemType = GetItemType(item.ItemTypeId);
            }

            return itemList;
        }

        private ItemTypeResponse GetItemType(int id)
        {
            return new ItemTypeResponse()
            {
                Name = "Some Name", 
                Description = "Some Description"
            };
        }
    }
}