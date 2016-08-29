using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Items.UpdateItem
{
    public class UpdateItemRepository : ICommandRepository<UpdateItemRequest>
    {
        public Task SaveChanges(UpdateItemRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}