using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Results;
using Core.Races.Requests;
using Core.Races.Responses;

namespace Core.Races
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository repo;

        public RaceService(IRaceRepository repo)
        {
            this.repo = repo;
        }

        public async Task<Result<IEnumerable<RaceResponse>>> GetRaces()
        {
            return await repo.GetRaces();    
        }

        public async Task<Result<RaceResponse>> GetRace(GetRaceRequest request)
        {
            if (request.Validate())
            {
                return await repo.GetRace(request);
            }

            return await Task.Run(() => new Result<RaceResponse>("Invalid Get Race request"));
        }

        public async Task<Result> InsertRace(InsertRaceRequest request)
        {
            if (request.Validate())
            {
                return await repo.InsertRace(request);
            }

            return await Task.Run(() => new Result("Invalid Insert Race request"));
        }

        public async Task<Result> UpdateRace(UpdateRaceRequest request)
        {
            if (request.Validate())
            {
                return await repo.UpdateRace(request);
            }

            return await Task.Run(() => new Result("Invalid Update Race request"));
        }

        public async Task<Result> DeleteRace(DeleteRaceRequest request)
        {
            if (request.Validate())
            {
                return await repo.DeleteRace(request);
            }

            return await Task.Run(() => new Result("Invalid Delete Race request"));
        }
    }
}
