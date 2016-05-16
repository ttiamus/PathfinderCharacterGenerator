using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Feat;
using MongoDB.Driver;

namespace DAL.Feat
{
    public class FeatRepository : IFeatRepository
    {
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Feat> Collection;

        public FeatRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Feat>("CollectionName");
        }

        public async Task<IEnumerable<Core.Feat.Feat>> GetFeats()
        {
            var Feats = await Collection.Find(x => true).ToListAsync();
            return Feats.Select(Feat => Feat.ToCore());
        }

        public async Task<Core.Feat.Feat> GetFeat(int id)
        {
            var Feat = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Feat.ToCore();
        }

        public async Task InsertFeat(Core.Feat.Feat Feat)
        {
            await Collection.InsertOneAsync(Feat.ToDal());
        }

        public async Task UpdateFeat(Feat Feat)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Feat.Id, Feat);
        }

        public async Task DeleteFeat(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
