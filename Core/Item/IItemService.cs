using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Item
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetItems();
        Task InsertItem(Item item);
    }
}
