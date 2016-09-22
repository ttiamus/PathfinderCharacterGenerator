using Core.V2.ItemTypes.CreateItemType;
using Core.V2.ItemTypes.Models;
using Core.V2.ItemTypes.UpdateItemType;
using MongoDB.Bson;

namespace Core.V2.ItemTypes
{
    public static class ItemTypeMapper
    {
        public static ItemTypeResponse ToItemReponse(this ItemType itemType)
        {
            return new ItemTypeResponse()
            {
                Id = itemType.ToString(),
                Name = itemType.Name,
                Description = itemType.Description
            };
        }

        public static ItemType ToItemType(this CreateItemTypeRequest request)
        {
            return new ItemType()
            {
                Name = request.Name,
                Description = request.Description
            };
        }

        public static ItemType ToItemType(this UpdateItemTypeRequest request)
        {
            return new ItemType()
            {
                Id = ObjectId.Parse(request.Id),
                Name = request.Name,
                Description = request.Description
            };
        }
    }
}