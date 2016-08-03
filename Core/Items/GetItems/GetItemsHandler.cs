using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.Items.GetItems
{
    public class GetItemsHandler : IQueryHandler<GetItemsRequest, GetItemsResponse>
    {
        private readonly IQueryRepository<GetItemsRequest, GetItemsResponse> repo;

        public GetItemsHandler(IQueryRepository<GetItemsRequest, GetItemsResponse> repo)
        {
            this.repo = repo;
        }

        public async Task<bool> Validate(GetItemsRequest item)
        {
            return await Task.Run(() => true);
        }

        public async Task<Result<GetItemsResponse>> Execute(GetItemsRequest item)
        {
            if (await Validate(item))
            {
                return await repo.SaveChanges(item);
            }
            return await Task.Run(() => new Result<GetItemsResponse>("Invalid Item"));
        }
    }
}
