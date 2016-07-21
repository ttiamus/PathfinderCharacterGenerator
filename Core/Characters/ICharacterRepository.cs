using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Characters
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetCharacters();
        Task<Character> GetCharacter(string id);
        Task InsertCharacter(Character character);
        Task UpdateCharacter(Character character);
        Task DeleteCharacter(string id);
    }
}
