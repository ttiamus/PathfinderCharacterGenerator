using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Items.UpdateItem
{
    public class UpdateItemHandler : ICommandHandler<UpdateItemRequest>
    {
        private readonly ICommandRepository<UpdateItemRequest> repo;

        public UpdateItemHandler(ICommandRepository<UpdateItemRequest> repo)
        {
            this.repo = repo;
        }

        public void Validate(UpdateItemRequest request)
        {
            
        }

        public async Task Execute(UpdateItemRequest request)
        {
            Validate(request);
            await repo.SaveChanges(request);
        }
    }
}