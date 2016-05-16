using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Weapon;
using MongoDB.Driver;

namespace DAL.Weapon
{
    public class WeaponRepository : IWeaponRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Weapon> collection;

        public WeaponRepository()
        {
            var database = client.GetDatabase("databaseName");
            collection = database.GetCollection<Weapon>("CollectionName");
        }

        public async Task<IEnumerable<Core.Weapon.Weapon>> GetWeapons()
        {
            var weapons = await collection.Find(x => true).ToListAsync();
            return weapons.Select(weapon => weapon.ToCore());
        }

        public async Task<Core.Weapon.Weapon> GetWeapon(int id)
        {
            var weapon = await collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return weapon.ToCore();
        }

        public async Task InsertWeapon(Core.Weapon.Weapon weapon)
        {
            await collection.InsertOneAsync(weapon.ToDal());
        }

        public async Task UpdateWeapon(Weapon weapon)
        {
            await collection.ReplaceOneAsync(x => x.Id == weapon.Id, weapon);
        }

        public async Task DeleteWeapon(int id)
        {
            await collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
