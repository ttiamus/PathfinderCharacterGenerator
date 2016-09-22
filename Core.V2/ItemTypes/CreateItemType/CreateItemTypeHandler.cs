using System;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.ItemTypes.CreateItemType
{
    public class CreateItemTypeHandler : ICommandHandler<CreateItemTypeRequest>
    {
        private readonly ICommandRepository<CreateItemTypeRequest> repo;

        public CreateItemTypeHandler(ICommandRepository<CreateItemTypeRequest> repo)
        {
            this.repo = repo;
        }

        public void Validate(CreateItemTypeRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new ArgumentException("Name was null or empty");

            if (string.IsNullOrWhiteSpace(request.Description))
                throw new ArgumentException("Description was null or empty");
        }

        public async Task Execute(CreateItemTypeRequest request)
        {
            Validate(request);
            await repo.SaveChanges(request);
        }
    }
}