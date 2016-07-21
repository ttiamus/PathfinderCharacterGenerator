using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Items
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItem(string id);
        Task<bool> InsertItem(Item item);
        Task<bool> UpdateItem(Item item);
        Task<bool> DeleteItem(string id);
    }
}
