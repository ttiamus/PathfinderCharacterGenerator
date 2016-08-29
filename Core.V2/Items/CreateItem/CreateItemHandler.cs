using System.Threading.Tasks;
using System.Windows.Input;
using Common.Interfaces;

namespace Core.V2.Items.CreateItem
{
    public class CreateItemHandler : ICommandHandler<CreateItemRequest>
    {
        private readonly ICommandRepository<CreateItemRequest> repo;

        public CreateItemHandler(ICommandRepository<CreateItemRequest> repo)
        {
            this.repo = repo;
        }

        public void Validate(CreateItemRequest request)
        {
            
        }

        public async Task Execute(CreateItemRequest request)
        {
            Validate(request);
            await repo.SaveChanges(request);
        }
    }
}