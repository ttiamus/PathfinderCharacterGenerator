using Core.Enum;
using MongoDB.Bson;

namespace DAL.Items
{
    public class Item
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
