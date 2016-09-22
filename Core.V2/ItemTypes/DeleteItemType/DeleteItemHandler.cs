using System;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.ItemTypes.DeleteItemType
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
            if(string.IsNullOrWhiteSpace(request.Id))
                throw new ArgumentException("Id was null or white space");
        }

        public async Task Execute(DeleteItemRequest request)
        {
            Validate(request);
            await repo.SaveChanges(request);
        }
    }
}