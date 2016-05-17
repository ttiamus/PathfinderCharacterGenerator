using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Weapon;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Weapon
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Weapon> collection;

        public WeaponRepository()
        {
            var database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Weapon>("Weapons");
        }

        public async Task<IEnumerable<Core.Weapon.Weapon>> GetWeapons()
        {
            var weapons = await collection.Find(x => true).ToListAsync();
            return weapons.Select(weapon => weapon.ToCore());
        }

        public async Task<Core.Weapon.Weapon> GetWeapon(string id)
        {
            var weapon = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return weapon.ToCore();
        }

        public async Task InsertWeapon(Core.Weapon.Weapon weapon)
        {
            await collection.InsertOneAsync(weapon.ToDal());
        }

        public async Task UpdateWeapon(Core.Weapon.Weapon weapon)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(weapon.Id)), weapon.ToDal());
        }

        public async Task DeleteWeapon(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
