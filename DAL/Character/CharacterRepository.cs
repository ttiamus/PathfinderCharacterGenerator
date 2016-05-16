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
        private readonly MongoClient client = new MongoClient("mongodb://localhost:27017");
        private readonly IMongoCollection<Character> collection;

        public CharacterRepository()
        {
            var database = client.GetDatabase("databaseName");
            collection = database.GetCollection<Character>("CollectionName");
        }

        public async Task<IEnumerable<Core.Character.Character>> GetCharacters()
        {
            var characters = await collection.Find(x => true).ToListAsync();
            return characters.Select(character => character.ToCore());
        }

        public async Task<Core.Character.Character> GetCharacter(int id)
        {
            var character = await collection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return character.ToCore();
        }

        public async Task InsertCharacter(Core.Character.Character character)
        {
            await collection.InsertOneAsync(character.ToDal());
        }

        public async Task UpdateCharacter(Character character)
        {
            await collection.ReplaceOneAsync(x => x.Id == character.Id, character);
        }

        public async Task DeleteCharacter(int id)
        {
            await collection.DeleteOneAsync(x => x.Id == id);
        }
    }
}
