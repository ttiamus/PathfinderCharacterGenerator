using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Items.Requests;
using Core.Items.Resposnes;

namespace Core.Items
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository itemRepo;

        public ItemService(IItemRepository itemRepo)
        {
            this.itemRepo = itemRepo;
        }
    
        public async Task<Result<IEnumerable<ItemResponse>>> GetItems()
        {
            return await itemRepo.GetItems();
        }

        public async Task<Result<ItemResponse>> GetItem(GetItemRequest request)
        {
            return await itemRepo.GetItem(request);
        }

        public async Task<Result> InsertItem(InsertItemRequest request)
        {
            try
            {
                if (request.Validate())
                {
                    return await itemRepo.InsertItem(request);
                }

                return await Task.Run(() => new Result("Invalid Insert Item Request"));
            }
            catch (Exception e)
            {
                return await Task.Run(() => new Result(e));
            }
        }

        public async Task<Result> UpdateItem(UpdateItemRequest request)
        {
            try
            {
                if (request.Validate())
                {
                    return await itemRepo.UpdateItem(request);
                }

                return await Task.Run(() => new Result("Invalid Update Item Request"));
            }
            catch (Exception e)
            {
                return await Task.Run(() => new Result(e));
            }
        }

        public async Task<Result> DeleteItem(DeleteItemRequest request)
        {
            try
            {
                if (request.Validate())
                {
                    return await itemRepo.DeleteItem(request);
                }

                return await Task.Run(() => new Result("Invalid Delete Item Request"));
            }
            catch (Exception e)
            {
                return await Task.Run(() => new Result(e));
            }
        }
    }
}
