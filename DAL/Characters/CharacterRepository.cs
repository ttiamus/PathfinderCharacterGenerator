using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Common.Configuration;
using Core.Characters;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL.Characters
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly IMongoCollection<Character> collection;
        private readonly IApplicationConfiguration config;

        public CharacterRepository(IApplicationConfiguration config)
        {
            this.config = config;
            var client = new MongoClient(config.PathfinderConnectionString);
            var database = client.GetDatabase("character");
            collection = database.GetCollection<Character>("Characters");
        }

        public async Task<IEnumerable<Core.Characters.Character>> GetCharacters()
        {
            var characters = await collection.Find(x => true).ToListAsync();
            return characters.Select(character => character.ToCore());
        }

        public async Task<Core.Characters.Character> GetCharacter(string id)
        {
            var character = await collection.Find(x => x.Id.Equals(ObjectId.Parse(id))).FirstOrDefaultAsync();
            return character.ToCore();
        }

        public async Task InsertCharacter(Core.Characters.Character character)
        {
            await collection.InsertOneAsync(character.ToDal());
        }

        public async Task UpdateCharacter(Core.Characters.Character character)
        {
            await collection.ReplaceOneAsync(x => x.Id.Equals(ObjectId.Parse(character.Id)), character.ToDal());
        }

        public async Task DeleteCharacter(string id)
        {
            await collection.DeleteOneAsync(x => x.Id.Equals(ObjectId.Parse(id)));
        }
    }
}
