using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Core.Weapons;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Weapons
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly IMongoCollection<Weapon> collection;

        public WeaponRepository()
        {
            var client = new MongoClient(ApplicationConfiguration.PathfinderConnectionString);
            var database = client.GetDatabase("pathfinder");
            collection = database.GetCollection<Weapon>("Weapons");
        }

        public async Task<IEnumerable<Core.Weapons.Weapon>> GetWeapons()
        {
            var weapons = await collection.Find(x => true).ToListAsync();
            return weapons.Select(weapon => weapon.ToCore());
        }

        public async Task<Core.Weapons.Weapon> GetWeapon(string id)
        {
            var weapon = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return weapon.ToCore();
        }

        public async Task InsertWeapon(Core.Weapons.Weapon weapon)
        {
            await collection.InsertOneAsync(weapon.ToDal());
        }

        public async Task UpdateWeapon(Core.Weapons.Weapon weapon)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(weapon.Id)), weapon.ToDal());
        }

        public async Task DeleteWeapon(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
