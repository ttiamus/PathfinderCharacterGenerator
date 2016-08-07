using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Items.Requests;
using Core.Items.Resposnes;

namespace Core.Items
{
    public interface IItemRepository
    {
        Task<Result<IEnumerable<ItemResponse>>> GetItems();
        Task<Result<ItemResponse>> GetItem(GetItemRequest request);
        Task<Result> InsertItem(InsertItemRequest request);
        Task<Result> UpdateItem(UpdateItemRequest request);
        Task<Result> DeleteItem(DeleteItemRequest request);
    }
}
