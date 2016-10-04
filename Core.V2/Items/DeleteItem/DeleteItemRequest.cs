namespace Core.V2.Items.DeleteItem
{
    public class DeleteItemRequest
    {
        public string Id { get; set; }

        public DeleteItemRequest(string id)
        {
            this.Id = id;
        }
    }
}
