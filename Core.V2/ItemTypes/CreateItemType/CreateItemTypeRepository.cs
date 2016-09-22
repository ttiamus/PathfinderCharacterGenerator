using System.Threading.Tasks;
using Common.Configuration.EnvironmentConfiguration;
using Common.Interfaces;

namespace Core.V2.ItemTypes.CreateItemType
{
    public class CreateItemTypeRepository : ItemTypeRepository, ICommandRepository<CreateItemTypeRequest>
    {
        public CreateItemTypeRepository(IEnvironmentConfiguration config) : base(config) { }

        public async Task SaveChanges(CreateItemTypeRequest request)
        {
            await collection.InsertOneAsync(request.ToItemType());
        }
    }
}