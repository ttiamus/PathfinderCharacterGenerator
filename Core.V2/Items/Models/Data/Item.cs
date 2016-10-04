using MongoDB.Bson;

namespace Core.V2.Items.Models.Data
{
    public class Item
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemTypeId { get; set; } //TODO: This should be an object Id
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}