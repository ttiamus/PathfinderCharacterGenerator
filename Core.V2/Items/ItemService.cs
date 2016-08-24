using System;
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
    public class ItemService : IItemService
    {
        public Task<Result<IEnumerable<ItemResponse>>> GetItems()
        {
            throw new NotImplementedException();
        }

        public Task<Result<ItemResponse>> GetItem(GetItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Result> InsertItem(CreateItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Result> UpdateItem(UpdateItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteItem(DeleteItemRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
