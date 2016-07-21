using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Core.Races;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Races
{
    public class RaceRepository : IRaceRepository
    {
        private readonly IMongoCollection<Race> collection;

        public RaceRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Race>("Races");
        }

        public async Task<IEnumerable<Core.Races.Race>> GetRaces()
        {
            var races = await collection.Find(x => true).ToListAsync();
            return races.Select(race => race.ToCore());
        }

        public async Task<Core.Races.Race> GetRace(string id)
        {
            var race = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return race.ToCore();
        }

        public async Task InsertRace(Core.Races.Race race)
        {
            await collection.InsertOneAsync(race.ToDal());
        }

        public async Task UpdateRace(Core.Races.Race race)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(race.Id)), race.ToDal());
        }

        public async Task DeleteRace(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
