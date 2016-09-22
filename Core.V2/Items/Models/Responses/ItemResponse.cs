using Core.V2.ItemTypes.Models;

namespace Core.V2.Items.Models.Responses
{
    public class ItemResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
        public ItemTypeResponse ItemType { get; set; }
    }
}
