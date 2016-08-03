using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.Items.UpdateItem
{
    public class UpdateItemHandler : ICommandHandler<UpdateItemRequest>
    {
        private readonly ICommandRepository<UpdateItemRequest> repo;

        public UpdateItemHandler(ICommandRepository<UpdateItemRequest> repo)
        {
            this.repo = repo;
        }

        public async Task<bool> Validate(UpdateItemRequest item)
        {
            return await Task.Run(() =>
                !string.IsNullOrWhiteSpace(item.Id) && 
                !string.IsNullOrWhiteSpace(item.Name));
            
            //Decimal types default to 0 
            //Will have to change to nullable decimal if I want to check them.
        }

        public async Task<CommandResult> Execute(UpdateItemRequest item)
        {
            if (await Validate(item))
            {
                return await repo.SaveChanges(item);
            }

            return await Task.Run(() => new CommandResult("Invalid item"));
        }
    }
}
