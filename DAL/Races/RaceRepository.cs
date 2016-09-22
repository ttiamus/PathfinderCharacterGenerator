using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Configuration.EnvironmentConfiguration;
using Common.Results;
using Core.Races;
using Core.Races.Requests;
using Core.Races.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Races
{
    public class RaceRepository : IRaceRepository
    {
        private readonly IMongoCollection<Race> collection;
        private readonly IEnvironmentConfiguration config;
        public RaceRepository(IEnvironmentConfiguration config)
        {
            this.config = config;
            var client = new MongoClient(config.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Race>("Races");
        }

        public async Task<Result<IEnumerable<RaceResponse>>> GetRaces()
        {
            var result = await collection.Find(x => true).ToListAsync();
            var races = result.Select(race => race.ToRaceResponse());
            return await Task.Run(() => new Result<IEnumerable<RaceResponse>>(races));
        }

        public async Task<Result<RaceResponse>> GetRace(GetRaceRequest request)
        {
            var race = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            return await Task.Run(() => new Result<RaceResponse>(race.ToRaceResponse()));
        }

        public async Task<Result> InsertRace(InsertRaceRequest request)
        {
            await collection.InsertOneAsync(request.ToRace());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> UpdateRace(UpdateRaceRequest request)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)), request.ToRace());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> DeleteRace(DeleteRaceRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
            return await Task.Run(() => new Result());
        }
    }
}
