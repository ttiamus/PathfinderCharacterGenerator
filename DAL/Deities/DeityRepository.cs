using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Core.Deites;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Deities
{
    public class DeityRepository : IDeityRepository
    {
        private readonly IMongoCollection<Deity> collection;

        public DeityRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Deity>("Deities");
        }

        public async Task<IEnumerable<Core.Deites.Deity>> GetDeities()
        {
            var deitys = await collection.Find(x => true).ToListAsync();
            return deitys.Select(deity => deity.ToCore());
        }

        public async Task<Core.Deites.Deity> GetDeity(string id)
        {
            var deity = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return deity.ToCore();
        }

        public async Task InsertDeity(Core.Deites.Deity deity)
        {
            await collection.InsertOneAsync(deity.ToDal());
        }

        public async Task UpdateDeity(Core.Deites.Deity deity)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(deity.Id)), deity.ToDal());
        }

        public async Task DeleteDeity(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
