using Core.Items.Requests;
using Core.Items.Resposnes;
using MongoDB.Bson;

namespace DAL.Items
{
    public static class ItemMapper
    {
        public static ItemResponse ToItemResponse(this Item item)
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

        public static Item ToItem(this InsertItemRequest request)
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
