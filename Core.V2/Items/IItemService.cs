using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetItem;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;

namespace Core.V2.Items
{
    public interface IItemService
    {
        Task<Result<IEnumerable<ItemResponse>>> GetItems();
        Task<Result<ItemResponse>> GetItem(GetItemRequest request);
        Task<Result> InsertItem(CreateItemRequest request);
        Task<Result> UpdateItem(UpdateItemRequest request);
        Task<Result> DeleteItem(DeleteItemRequest request);
    }
}
