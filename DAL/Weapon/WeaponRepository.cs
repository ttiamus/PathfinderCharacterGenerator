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
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Weapon> Collection;

        public WeaponRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Weapon>("CollectionName");
        }

        public async Task<IEnumerable<Core.Weapon.Weapon>> GetWeapons()
        {
            var Weapons = await Collection.Find(x => true).ToListAsync();
            return Weapons.Select(Weapon => Weapon.ToCore());
        }

        public async Task<Core.Weapon.Weapon> GetWeapon(int id)
        {
            var Weapon = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Weapon.ToCore();
        }

        public async Task InsertWeapon(Core.Weapon.Weapon Weapon)
        {
            await Collection.InsertOneAsync(Weapon.ToDal());
        }

        public async Task UpdateWeapon(Weapon Weapon)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Weapon.Id, Weapon);
        }

        public async Task DeleteWeapon(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
