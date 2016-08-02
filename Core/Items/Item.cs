using MongoDB.Bson;

namespace Core.Items
{
    public class Item
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
