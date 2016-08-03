using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Items.DeleteItem;
using Core.Items.GetItem;
using Core.Items.GetItems;
using Core.Items.InsertItem;
using Core.Items.UpdateItem;

namespace Core.Items
{
    public interface IItemService
    {
        Task<Result> DeleteItem(DeleteItemRequest item);
        Task<Result<GetItemResponse>> GetItem(GetItemRequest item);
        Task<Result<List<GetItemsResponse>>> GetItems(GetItemsRequest item);
        Task<Result> InsertItem(InsertItemRequest item);
        Task<Result> UpdateItem(UpdateItemRequest item);


        /*Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItem(string id);
        Task<bool> InsertItem(Item item);
        Task<bool> UpdateItem(Item item);
        Task<bool> DeleteItem(string id);*/
    }
}
