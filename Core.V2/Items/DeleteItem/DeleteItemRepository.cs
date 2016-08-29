using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Items.DeleteItem
{
    public class DeleteItemRepository : ICommandRepository<DeleteItemRequest>
    {
        public Task SaveChanges(DeleteItemRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}