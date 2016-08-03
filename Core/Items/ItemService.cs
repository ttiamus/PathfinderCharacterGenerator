using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Items.DeleteItem;
using Core.Items.GetItem;
using Core.Items.GetItems;
using Core.Items.InsertItem;
using Core.Items.UpdateItem;
using Common.Interfaces;

namespace Core.Items
{
    public class ItemService : IItemService
    {
        private readonly ICommandHandler<DeleteItemRequest> deleteItem;
        private readonly IQueryHandler<GetItemRequest, GetItemResponse> getItem;
        private readonly IQueryHandler<GetItemsRequest, List<GetItemsResponse>> getItems;
        private readonly ICommandHandler<InsertItemRequest> insertItem;
        private readonly ICommandHandler<UpdateItemRequest> updateItem;

        ItemService(
            ICommandHandler<DeleteItemRequest> deleteItem,
            IQueryHandler<GetItemRequest, GetItemResponse> getItem,
            IQueryHandler<GetItemsRequest, List<GetItemsResponse>> getItems,
            ICommandHandler<InsertItemRequest> insertItem,
            ICommandHandler<UpdateItemRequest> updateItem)
        {
            this.deleteItem = deleteItem;
            this.getItem = getItem;
            this.getItems = getItems;
            this.insertItem = insertItem;
            this.updateItem = updateItem;
        }

        public async Task<Result> DeleteItem(DeleteItemRequest item)
        {
            return await deleteItem.Execute(item);
        }

        public async  Task<Result<GetItemResponse>> GetItem(GetItemRequest item)
        {
            return await getItem.Execute(item);
        }

        public async Task<Result<List<GetItemsResponse>>> GetItems(GetItemsRequest item)
        {
            return await getItems.Execute(item);
        }

        public async Task<Result> InsertItem(InsertItemRequest item)
        {
            return await insertItem.Execute(item);
        }

        public async Task<Result> UpdateItem(UpdateItemRequest item)
        {
            return await updateItem.Execute(item);
        }

        /*private readonly IItemRepository itemRepo;

        public ItemService(IItemRepository itemRepo)
        {
            this.itemRepo = itemRepo;
        }
    
        public Task<IEnumerable<Item>> GetItems()
        {
            return itemRepo.GetItems();
        }

        public Task<Item> GetItem(string id)
        {
            return itemRepo.GetItem(id);
        }

        public async Task<bool> InsertItem(Item item)
        {
            try
            {
                await itemRepo.InsertItem(item);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> UpdateItem(Item item)
        {
            try
            {
                await itemRepo.UpdateItem(item);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> DeleteItem(string id)
        {
            try
            {
                await itemRepo.DeleteItem(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }*/
    }
}
