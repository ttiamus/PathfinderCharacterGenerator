﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Feat;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Feat
{
    public class FeatRepository : IFeatRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://tiamus-mongodb.southcentralus.cloudapp.azure.com");
        IMongoCollection<Feat> collection;

        public FeatRepository()
        {
            var database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Feat>("Feats");
        }

        public async Task<IEnumerable<Core.Feat.Feat>> GetFeats()
        {
            var feats = await collection.Find(x => true).ToListAsync();
            return feats.Select(feat => feat.ToCore());
        }

        public async Task<Core.Feat.Feat> GetFeat(string id)
        {
            var feat = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return feat.ToCore();
        }

        public async Task InsertFeat(Core.Feat.Feat feat)
        {
            await collection.InsertOneAsync(feat.ToDal());
        }

        public async Task UpdateFeat(Core.Feat.Feat feat)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(feat.Id)), feat.ToDal());
        }

        public async Task DeleteFeat(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
