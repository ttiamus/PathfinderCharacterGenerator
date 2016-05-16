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
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        IMongoCollection<Feat> collection;

        public FeatRepository()
        {
            var database = client.GetDatabase("databaseName");
            collection = database.GetCollection<Feat>("CollectionName");
        }

        public async Task<IEnumerable<Core.Feat.Feat>> GetFeats()
        {
            var feats = await collection.Find(x => true).ToListAsync();
            return feats.Select(feat => feat.ToCore());
        }

        public async Task<Core.Feat.Feat> GetFeat(int id)
        {
            var feat = await collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return feat.ToCore();
        }

        public async Task InsertFeat(Core.Feat.Feat feat)
        {
            await collection.InsertOneAsync(feat.ToDal());
        }

        public async Task UpdateFeat(Feat feat)
        {
            await collection.ReplaceOneAsync(x => x.Id == feat.Id, feat);
        }

        public async Task DeleteFeat(int id)
        {
            await collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
