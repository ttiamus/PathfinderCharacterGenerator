using Core.V2.Items.CreateItem;
using Core.V2.Items.Models.Data;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;
using MongoDB.Bson;

namespace Core.V2.Items
{
    public static class ItemExtensions
    {
        public static ItemResponse ToItemReponse(this Item item)
        {
            return new ItemResponse()
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                ItemTypeId = item.ItemTypeId,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }

        public static Item ToItem(this CreateItemRequest request)
        {
            return new Item()
            {
                Name = request.Name,
                ItemTypeId = request.ItemTypeId,
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
                ItemTypeId = request.ItemTypeId,
                Cost = request.Cost,
                Weight = request.Weight
            };
        }
    }
}
