using System.Threading.Tasks;
using Common.Configuration.EnvironmentConfiguration;
using Common.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Core.V2.ItemTypes.DeleteItemType
{
    public class DeleteItemRepository : ItemTypeRepository, ICommandRepository<DeleteItemRequest>
    {
        public DeleteItemRepository(IEnvironmentConfiguration config) : base(config) { }

        public async Task SaveChanges(DeleteItemRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
        }
    }
}