using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Items
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository itemRepo;

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
        }
    }
}
