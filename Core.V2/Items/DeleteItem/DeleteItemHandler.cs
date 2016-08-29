using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Items.DeleteItem
{
    public class DeleteItemHandler : ICommandHandler<DeleteItemRequest>
    {
        private readonly ICommandRepository<DeleteItemRequest> repo;

        public DeleteItemHandler(ICommandRepository<DeleteItemRequest> repo)
        {
            this.repo = repo;
        }

        public void Validate(DeleteItemRequest request)
        {
            
        }

        public async Task Execute(DeleteItemRequest request)
        {
            Validate(request);
            await repo.SaveChanges(request);
        }
    }
}