using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Race;
using MongoDB.Driver;

namespace DAL.Race
{
    public class RaceRepository : IRaceRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Race> collection;

        public RaceRepository()
        {
            IMongoDatabase database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Race>("Races");
        }

        public async Task<IEnumerable<Core.Race.Race>> GetRaces()
        {
            var races = await collection.Find(x => true).ToListAsync();
            return races.Select(race => race.ToCore());
        }

        public async Task<Core.Race.Race> GetRace(string id)
        {
            var race = await collection.Find(x => x.Id.ToLower().Equals(id.ToLower())).FirstOrDefaultAsync();
            return race.ToCore();
        }

        public async Task InsertRace(Core.Race.Race race)
        {
            await collection.InsertOneAsync(race.ToDal());
        }

        public async Task UpdateRace(Race race)
        {
            await collection.ReplaceOneAsync(x => x.Id.ToLower().Equals(race.Id.ToLower()), race);
        }

        public async Task DeleteRace(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.ToLower().Equals(id.ToLower()));
        }
    }
}
