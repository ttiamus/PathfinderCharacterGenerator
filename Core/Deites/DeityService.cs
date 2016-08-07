using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Deites.Requests;
using Core.Deites.Responses;

namespace Core.Deites
{
    public class DeityService : IDeityService
    {
        private readonly IDeityRepository repo;

        public DeityService(IDeityRepository repo)
        {
            this.repo = repo;
        }

        public async Task<Result<IEnumerable<DeityResponse>>> GetDeities()
        {
            return await repo.GetDeities();
        }

        public async Task<Result<DeityResponse>> GetDeity(GetDeityRequest request)
        {
            return await repo.GetDeity(request);
        }

        public async Task<Result> InsertDeity(InsertDeityRequest request)
        {
            return await repo.InsertDeity(request);
        }

        public async Task<Result> UpdateDeity(UpdateDeityRequest request)
        {
            return await repo.UpdateDeity(request);
        }

        public async Task<Result> DeleteDeity(DeleteDeityRequest request)
        {
            return await repo.DeleteDeity(request);
        }
    }
}
