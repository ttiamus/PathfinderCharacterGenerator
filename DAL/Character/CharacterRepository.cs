using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Character;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Character
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly MongoClient client = new MongoClient("mongodb://tiamus-mongodb.southcentralus.cloudapp.azure.com");
        private readonly IMongoCollection<Character> collection;

        public CharacterRepository()
        {
            var database = client.GetDatabase("CharacterGenerator");
            collection = database.GetCollection<Character>("Characters");
        }

        public async Task<IEnumerable<Core.Character.Character>> GetCharacters()
        {
            var characters = await collection.Find(x => true).ToListAsync();
            return characters.Select(character => character.ToCore());
        }

        public async Task<Core.Character.Character> GetCharacter(string id)
        {
            var character = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return character.ToCore();
        }

        public async Task InsertCharacter(Core.Character.Character character)
        {
            await collection.InsertOneAsync(character.ToDal());
        }

        public async Task UpdateCharacter(Core.Character.Character character)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(character.Id)), character.ToDal());
        }

        public async Task DeleteCharacter(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
