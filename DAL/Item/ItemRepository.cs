using System;
using System.Collections.Generic;
using Core.Item;

namespace DAL.Item
{
    public class ItemRepository : IItemRepository
    {
        public ItemRepository()
        {
        }

        public IEnumerable<Core.Item.Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public Core.Item.Item GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Item.Item ToCore(Item dal)
        {
            return new Core.Item.Item()
            {

            };
        }

        private Item ToDal(Core.Item.Item core)
        {
            return new Item()
            {

            };
        }
    }
}
