using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Deites.Requests;
using Core.Deites.Responses;

namespace Core.Deites
{
    public interface IDeityService
    {
        Task<Result<IEnumerable<DeityResponse>>> GetDeities();
        Task<Result<DeityResponse>> GetDeity(GetDeityRequest request);
        Task<Result> InsertDeity(InsertDeityRequest request);
        Task<Result> UpdateDeity(UpdateDeityRequest request);
        Task<Result> DeleteDeity(DeleteDeityRequest request);
    }
}
