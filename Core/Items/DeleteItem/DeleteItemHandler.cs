using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;
using Core.Items.InsertItem;

namespace Core.Items.DeleteItem
{
    public class DeleteItemHandler : ICommandHandler<DeleteItemRequest>
    {
        private readonly ICommandRepository<DeleteItemRequest> repo;

        public DeleteItemHandler(ICommandRepository<DeleteItemRequest> repo)
        {
            this.repo = repo;
        }

        public async Task<bool> Validate(DeleteItemRequest item)
        {
            return await Task.Run(() => !string.IsNullOrWhiteSpace(item.Id));

            //Decimal types default to 0 
            //Will have to change to nullable decimal if I want to check them.
        }

        public async Task<Result> Execute(DeleteItemRequest item)
        {
            if (await Validate(item))
            {
                return await repo.SaveChanges(item);
            }
            return await Task.Run(() => new Result("Invalid Item"));
        }
    }
}
