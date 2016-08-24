using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.V2.Races.CreateRace;
using Core.V2.Races.DeleteRace;
using Core.V2.Races.GetRace;
using Core.V2.Races.Models.Responses;
using Core.V2.Races.UpdateRace;

namespace Core.V2.Races
{
    public interface IRaceService
    {
        Task<Result<IEnumerable<RaceResponse>>> GetRaces();
        Task<Result<RaceResponse>> GetRace(GetRaceRequest request);
        Task<Result> InsertRace(CreateRaceRequest request);
        Task<Result> UpdateRace(UpdateRaceRequest request);
        Task<Result> DeleteRace(DeleteRaceRequest request);
    }
}
