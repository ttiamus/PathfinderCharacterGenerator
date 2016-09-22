using System.Threading.Tasks;
using Common.Configuration;
using Common.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.V2.Items.UpdateItem
{
    public class UpdateItemRepository : ItemRepository, ICommandRepository<UpdateItemRequest>
    {
        public UpdateItemRepository(IApplicationConfiguration config) : base(config.GetConfiguration())
        {
            //this.config = config;
        }

        public async Task SaveChanges(UpdateItemRequest request)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)), request.ToItem());
        }
    }
}