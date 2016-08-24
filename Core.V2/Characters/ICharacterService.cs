using System.Collections.Generic;
using System.Threading.Tasks;
using Core.V2.Characters.Models.Data;

namespace Core.V2.Characters
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
