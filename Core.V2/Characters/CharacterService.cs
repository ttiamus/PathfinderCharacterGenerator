﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.V2.Characters.Models.Data;

namespace Core.V2.Characters
{
    public class CharacterService : ICharacterService
    {
        public Task<IEnumerable<Character>> GetCharacters()
        {
            throw new System.NotImplementedException();
        }

        public Task<Character> GetCharacter(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertCharacter(Character character)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateCharacter(Character character)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteCharacter(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
