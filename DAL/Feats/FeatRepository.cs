using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Core.Feats;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Feats
{
    public class FeatRepository : IFeatRepository
    {
        private readonly IMongoCollection<Feat> collection;
        private readonly IApplicationConfiguration config;
        public FeatRepository(IApplicationConfiguration config)
        {
            this.config = config;
            var client = new MongoClient(config.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Feat>("Feats");
        }

        public async Task<IEnumerable<Core.Feats.Feat>> GetFeats()
        {
            var feats = await collection.Find(x => true).ToListAsync();
            return feats.Select(feat => feat.ToCore());
        }

        public async Task<Core.Feats.Feat> GetFeat(string id)
        {
            var feat = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return feat.ToCore();
        }

        public async Task InsertFeat(Core.Feats.Feat feat)
        {
            await collection.InsertOneAsync(feat.ToDal());
        }

        public async Task UpdateFeat(Core.Feats.Feat feat)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(feat.Id)), feat.ToDal());
        }

        public async Task DeleteFeat(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
