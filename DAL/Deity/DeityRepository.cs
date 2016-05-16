using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Deity;
using MongoDB.Driver;

namespace DAL.Deity
{
    public class DeityRepository : IDeityRepository
    {
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Deity> Collection;

        public DeityRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Deity>("CollectionName");
        }

        public async Task<IEnumerable<Core.Deity.Deity>> GetDeitys()
        {
            var Deitys = await Collection.Find(x => true).ToListAsync();
            return Deitys.Select(Deity => Deity.ToCore());
        }

        public async Task<Core.Deity.Deity> GetDeity(int id)
        {
            var Deity = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Deity.ToCore();
        }

        public async Task InsertDeity(Core.Deity.Deity Deity)
        {
            await Collection.InsertOneAsync(Deity.ToDal());
        }

        public async Task UpdateDeity(Deity Deity)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Deity.Id, Deity);
        }

        public async Task DeleteDeity(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
