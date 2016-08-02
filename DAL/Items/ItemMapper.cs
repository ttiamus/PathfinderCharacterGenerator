using Core.Items.UpdateItem;
using MongoDB.Bson;

namespace DAL.Items
{
    public static class ItemMapper
    {
        public static Core.Items.Item ToCore(this Item dal)
        {
            return new Core.Items.Item()
            {
                //Id = dal.Id.ToString(),
                Cost = dal.Cost,
                Weight = dal.Weight,
                Name = dal.Name
            };
        }

        public static Item ToDal(this Core.Items.Item core)
        {
            var item = new Item()
            {
                Cost = core.Cost,
                Weight = core.Weight,
                Name = core.Name
            };

           /* if (!string.IsNullOrWhiteSpace(core.Id))
            {
                item.Id = ObjectId.Parse(core.Id);
            }*/

            return item;
        }

        public static Item ToItem(this UpdateItemRequest item)
        {
            return new Item()
            {
                Id = ObjectId.Parse(item.Id),
                Name = item.Name,
                Cost = item.Cost,
                Weight = item.Weight
            };
        }
    }
}
