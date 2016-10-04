namespace Core.V2.Items.GetItem
{
    public class GetItemRequest
    {
        public string Id { get; set; }

        public GetItemRequest(string id)
        {
            this.Id = id;
        }
    }
}
