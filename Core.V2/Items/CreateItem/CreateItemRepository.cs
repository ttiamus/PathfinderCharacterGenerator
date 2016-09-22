using System.Threading.Tasks;
using Common.Configuration;
using Common.Interfaces;

namespace Core.V2.Items.CreateItem
{
    public class CreateItemRepository : ItemRepository, ICommandRepository<CreateItemRequest>
    {
        public CreateItemRepository(IApplicationConfiguration config) : base(config.GetConfiguration()) { }

        public async Task SaveChanges(CreateItemRequest request)
        {
            await collection.InsertOneAsync(request.ToItem());
        }
    }
}