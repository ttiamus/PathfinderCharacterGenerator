using Core.Enum;

namespace Core.Items.Requests
{
    public class InsertItemRequest
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
