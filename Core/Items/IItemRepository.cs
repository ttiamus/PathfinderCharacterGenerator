using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Items
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItem(string id);
        Task InsertItem(Item item);
        Task UpdateItem(Item item);
        Task DeleteItem(string id);
    }
}
