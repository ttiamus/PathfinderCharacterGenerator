using Core.Items.Requests;

namespace Core.Items
{
    public static class ItemExtensions
    {
        public static bool Validate(this GetItemRequest item)
        {
            return item.Id != null;
        }

        public static bool Validate(this InsertItemRequest item)
        {
            return !string.IsNullOrWhiteSpace(item.Name);
        }

        public static bool Validate(this UpdateItemRequest item)
        {
            return item.Id != null
                && string.IsNullOrWhiteSpace(item.Name);
        }

        public static bool Validate(this DeleteItemRequest item)
        {
            return item.Id != null;
        }
    }
}
