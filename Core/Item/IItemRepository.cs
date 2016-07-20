using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Item
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetItems();
        Task InsertItem(Item item);
    }
}
