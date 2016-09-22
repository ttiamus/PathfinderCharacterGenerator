using System.Threading.Tasks;
using Common.Configuration;
using Common.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.V2.Items.DeleteItem
{
    public class DeleteItemRepository : ItemRepository, ICommandRepository<DeleteItemRequest>
    {
        public DeleteItemRepository(IApplicationConfiguration config) : base(config.GetConfiguration()) { }

        public async Task SaveChanges(DeleteItemRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
        }
    }
}