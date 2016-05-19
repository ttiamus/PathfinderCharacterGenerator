using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DAL.Item
{
    public static class ItemMapper
    {
        public static Core.Item.Item ToCore(this Item dal)
        {
            return new Core.Item.Item()
            {
                Id = dal.Id.ToString(),
                Cost = dal.Cost,
                Weight = dal.Weight,
                Name = dal.Name
            };
        }

        public static Item ToDal(this Core.Item.Item core)
        {
            var item = new Item()
            {
                Cost = core.Cost,
                Weight = core.Weight,
                Name = core.Name
            };

            if (!string.IsNullOrWhiteSpace(core.Id))
            {
                item.Id = ObjectId.Parse(core.Id);
            }

            return item;
        }
    }
}
