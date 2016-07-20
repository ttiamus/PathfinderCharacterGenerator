using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Item
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

        public Task InsertItem(Item item)
        {
            return itemRepo.InsertItem(item);
        }
    }
}
