using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetItem;
using Core.V2.Items.UpdateItem;

namespace Core.V2.Items
{
    public static class ItemExtensions
    {
        public static bool Validate(this GetItemRequest item)
        {
            return item.Id != null;
        }

        public static bool Validate(this CreateItemRequest item)
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
