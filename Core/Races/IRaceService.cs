using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Races.Requests;
using Core.Races.Responses;

namespace Core.Races
{
    public interface IRaceService
    {
        Task<Result<IEnumerable<RaceResponse>>> GetRaces();
        Task<Result<RaceResponse>> GetRace(GetRaceRequest request);
        Task<Result> InsertRace(InsertRaceRequest request);
        Task<Result> UpdateRace(UpdateRaceRequest request);
        Task<Result> DeleteRace(DeleteRaceRequest request);
    }
}
