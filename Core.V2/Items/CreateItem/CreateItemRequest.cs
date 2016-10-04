namespace Core.V2.Items.CreateItem
{
    public class CreateItemRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ItemTypeId { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
