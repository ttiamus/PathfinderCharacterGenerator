using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Item
{
    public static class ItemMapper
    {
        public static Core.Item.Item ToCore(this Item dal)
        {
            return new Core.Item.Item()
            {

            };
        }

        public static Item ToDal(this Core.Item.Item core)
        {
            return new Item()
            {

            };
        }
    }
}
