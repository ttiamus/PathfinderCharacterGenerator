using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Deity;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Deity
{
    public class DeityRepository : IDeityRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Deity> collection;

        public DeityRepository()
        {
            var database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Deity>("Deities");
        }

        public async Task<IEnumerable<Core.Deity.Deity>> GetDeitys()
        {
            var deitys = await collection.Find(x => true).ToListAsync();
            return deitys.Select(deity => deity.ToCore());
        }

        public async Task<Core.Deity.Deity> GetDeity(string id)
        {
            var deity = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return deity.ToCore();
        }

        public async Task InsertDeity(Core.Deity.Deity deity)
        {
            await collection.InsertOneAsync(deity.ToDal());
        }

        public async Task UpdateDeity(Core.Deity.Deity deity)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(deity.Id)), deity.ToDal());
        }

        public async Task DeleteDeity(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
