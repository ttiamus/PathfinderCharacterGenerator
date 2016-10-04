using System;
using Core.V2.Items.CreateItem;
using Core.V2.Items.Models.Data;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;
using Core.V2.ItemTypes.Models;
using MongoDB.Bson;

namespace Core.V2.Items
{
    public static class ItemMappers
    {
        public static ItemResponse ToItemReponse(this Item item)
        {
            return new ItemResponse()
            {
                Id = item.Id.ToString(),
                Description = item.Description,
                Name = item.Name,
                ItemType = new ItemTypeResponse() { Id = item.ItemTypeId.ToString() },
                Cost = item.Cost,
                Weight = item.Weight
            };
        }

        public static Item ToItem(this CreateItemRequest request)
        {
            return new Item()
            {
                Name = request.Name,
                Description = request.Description,
                ItemTypeId = Convert.ToInt32(request.ItemTypeId),
                Cost = request.Cost,
                Weight = request.Weight
            };
        }

        public static Item ToItem(this UpdateItemRequest request)
        {
            return new Item()
            {
                Id = ObjectId.Parse(request.Id),
                Name = request.Name,
                Description = request.Description,
                ItemTypeId = Convert.ToInt32(request.ItemTypeId),
                Cost = request.Cost,
                Weight = request.Weight
            };
        }
    }
}
