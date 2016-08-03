using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.Items.GetItem
{
    public class GetItemHandler : IQueryHandler<GetItemRequest, GetItemResponse>
    {
        private readonly IQueryRepository<GetItemRequest, GetItemResponse> repo;

        public GetItemHandler(IQueryRepository<GetItemRequest, GetItemResponse> repo)
        {
            this.repo = repo;
        }

        public async Task<bool> Validate(GetItemRequest item)
        {
            return await Task.Run(() => !string.IsNullOrWhiteSpace(item.Id));
        }

        public async Task<Result<GetItemResponse>> Execute(GetItemRequest item)
        {
            if (await Validate(item))
            {
                return await repo.SaveChanges(item);
            }
            return await Task.Run(() => new Result<GetItemResponse>("Invalid Item"));
        }
    }
}
