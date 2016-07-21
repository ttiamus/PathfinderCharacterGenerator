using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Characters
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetCharacters();
        Task<Character> GetCharacter(string id);
        Task<bool> InsertCharacter(Character character);
        Task<bool> UpdateCharacter(Character character);
        Task<bool> DeleteCharacter(string id);
    }
}
