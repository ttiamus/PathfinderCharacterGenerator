using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Results;
using Core.Deites;
using Core.Deites.Requests;
using Core.Deites.Responses;
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

        public async Task<Result<IEnumerable<DeityResponse>>> GetDeities()
        {
            var result = await collection.Find(x => true).ToListAsync();
            var deities = result.Select(deity => deity.ToDeityResponse());
            return new Result<IEnumerable<DeityResponse>>(deities);
        }

        public async Task<Result<DeityResponse>> GetDeity(GetDeityRequest request)
        {
            var deity = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            return new Result<DeityResponse>(deity.ToDeityResponse());
        }

        public async Task<Result> InsertDeity(InsertDeityRequest request)
        {
            await collection.InsertOneAsync(request.ToDeity());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> UpdateDeity(UpdateDeityRequest request)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)), request.ToDeity());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> DeleteDeity(DeleteDeityRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
            return await Task.Run(() => new Result());
        }
    }
}
