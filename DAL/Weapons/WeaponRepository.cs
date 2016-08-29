using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Common.Results;
using Core.Weapons;
using Core.Weapons.Requests;
using Core.Weapons.Responses;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Weapons
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly IMongoCollection<Weapon> collection;
        private readonly IApplicationConfiguration config;

        public WeaponRepository(IApplicationConfiguration config)
        {
            this.config = config;
            var client = new MongoClient(config.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Weapon>("Weapons");
        }

        public async Task<Result<IEnumerable<WeaponResponse>>> GetWeapons()
        {
            var result = await collection.Find(x => true).ToListAsync();
            var weapons = result.Select(weapon => weapon.ToWeaponResponse());
            return await Task.Run(() => new Result<IEnumerable<WeaponResponse>>(weapons));
        }

        public async Task<Result<WeaponResponse>> GetWeapon(GetWeaponRequest request)
        {
            var weapon = await collection.Find(x => x.Id.Equals(ObjectId.Parse(request.Id))).FirstOrDefaultAsync();
            return await Task.Run(() => new Result<WeaponResponse>(weapon.ToWeaponResponse()));
        }

        public async Task<Result> InsertWeapon(InsertWeaponRequest request)
        {
            await collection.InsertOneAsync(request.ToWeapon());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> UpdateWeapon(UpdateWeaponRequest request)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)), request.ToWeapon());
            return await Task.Run(() => new Result());
        }

        public async Task<Result> DeleteWeapon(DeleteWeaponRequest request)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(request.Id)));
            return await Task.Run(() => new Result());
        }
    }
}
