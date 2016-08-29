using System.Collections.Generic;
using System.Threading.Tasks;
using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetAllItems;
using Core.V2.Items.GetItem;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;

namespace Core.V2.Items
{
    public interface IItemService
    {
        Task<List<ItemResponse>> GetAllItems(GetAllItemsRequest request);
        Task<ItemResponse> GetItem(GetItemRequest request);
        Task CreateItem(CreateItemRequest request);
        Task UpdateItem(UpdateItemRequest request);
        Task DeleteItem(DeleteItemRequest request);
    }
}
