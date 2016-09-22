namespace Core.Items.Requests
{
    public class UpdateItemRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
