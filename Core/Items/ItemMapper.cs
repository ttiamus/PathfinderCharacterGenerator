using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Items.GetItem;
using Core.Items.GetItems;
using Core.Items.InsertItem;
using Core.Items.UpdateItem;
using MongoDB.Bson;

namespace Core.Items
{
    public static class ItemMapper
    {
        public static Item ToItem(this UpdateItemRequest item)
        {
            return new Item()
            {
                Id = ObjectId.Parse(item.Id),
                Name = item.Name,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }

        public static Item ToItem(this InsertItemRequest item)
        {
            return new Item()
            {
                Name = item.Name,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }

        public static GetItemResponse ToItemResponse(this Item item)
        {
            return new GetItemResponse()
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }

        public static GetItemsResponse ToItemsResponse (this Item item)
        {
            return new GetItemsResponse()
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }
    }
}
