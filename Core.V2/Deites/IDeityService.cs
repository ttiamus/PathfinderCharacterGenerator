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
    public interface IDeityService
    {
        Task<Result<IEnumerable<DeityResponse>>> GetDeities();
        Task<Result<DeityResponse>> GetDeity(GetDeityRequest request);
        Task<Result> InsertDeity(CreateDeityRequest request);
        Task<Result> UpdateDeity(UpdateDeityRequest request);
        Task<Result> DeleteDeity(DeleteDeityRequest request);
    }
}
