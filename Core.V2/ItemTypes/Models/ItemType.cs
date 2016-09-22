using MongoDB.Bson;

namespace Core.V2.ItemTypes.Models
{
    public class ItemType
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}