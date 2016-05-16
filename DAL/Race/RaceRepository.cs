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
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Race> Collection;

        public RaceRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Race>("CollectionName");
        }

        public async Task<IEnumerable<Core.Race.Race>> GetRaces()
        {
            var Races = await Collection.Find(x => true).ToListAsync();
            return Races.Select(Race => Race.ToCore());
        }

        public async Task<Core.Race.Race> GetRace(int id)
        {
            var Race = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Race.ToCore();
        }

        public async Task InsertRace(Core.Race.Race Race)
        {
            await Collection.InsertOneAsync(Race.ToDal());
        }

        public async Task UpdateRace(Race Race)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Race.Id, Race);
        }

        public async Task DeleteRace(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
