using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Character;
using MongoDB.Driver;

namespace DAL.Character
{
    public class CharacterRepository : ICharacterRepository
    {
        MongoClient Client = new MongoClient("mongodb://localhost:27017");
        IMongoDatabase Database;
        IMongoCollection<Character> Collection;

        public CharacterRepository()
        {
            Database = Client.GetDatabase("databaseName");
            Collection = Database.GetCollection<Character>("CollectionName");
        }

        public async Task<IEnumerable<Core.Character.Character>> GetCharacters()
        {
            var Characters = await Collection.Find(x => true).ToListAsync();
            return Characters.Select(Character => Character.ToCore());
        }

        public async Task<Core.Character.Character> GetCharacter(int id)
        {
            var Character = await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return Character.ToCore();
        }

        public async Task InsertCharacter(Core.Character.Character Character)
        {
            await Collection.InsertOneAsync(Character.ToDal());
        }

        public async Task UpdateCharacter(Character Character)
        {
            await Collection.ReplaceOneAsync(x => x.Id == Character.Id, Character);
        }

        public async Task DeleteCharacter(int id)
        {
            await Collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
