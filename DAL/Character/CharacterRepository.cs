using System;
using System.Collections.Generic;
using Core.Character;

namespace DAL.Character
{
    public class CharacterRepository : ICharacterRepository
    {
        public CharacterRepository()
        {
        }

        public IEnumerable<Core.Character.Character> GetCharacters()
        {
            throw new NotImplementedException();
        }

        public Core.Character.Character GetCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCharacter(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Character.Character ToCore(Character dal)
        {
            return new Core.Character.Character()
            {

            };
        }

        private Character ToDal(Core.Character.Character core)
        {
            return new Character()
            {

            };
        }
    }
}
