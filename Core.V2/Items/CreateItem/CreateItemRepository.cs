using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Items.CreateItem
{
    public class CreateItemRepository : ICommandRepository<CreateItemRequest>
    {
        public Task SaveChanges(CreateItemRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}