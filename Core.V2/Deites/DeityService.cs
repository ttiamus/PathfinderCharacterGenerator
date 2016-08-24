using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.Deites.CreateDeity;
using Core.V2.Deites.DeleteDeity;
using Core.V2.Deites.GetDeity;
using Core.V2.Deites.Models.Responses;
using Core.V2.Deites.UpdateDeity;

namespace Core.V2.Deites
{
    public class DeityService : IDeityService
    {
        public Task<Result<IEnumerable<DeityResponse>>> GetDeities()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<DeityResponse>> GetDeity(GetDeityRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> InsertDeity(CreateDeityRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> UpdateDeity(UpdateDeityRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> DeleteDeity(DeleteDeityRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
