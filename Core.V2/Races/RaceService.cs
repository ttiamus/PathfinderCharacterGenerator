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
    public class RaceService : IRaceService
    {
        public Task<Result<IEnumerable<RaceResponse>>> GetRaces()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<RaceResponse>> GetRace(GetRaceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> InsertRace(CreateRaceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> UpdateRace(UpdateRaceRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> DeleteRace(DeleteRaceRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
