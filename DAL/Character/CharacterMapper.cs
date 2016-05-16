using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Character
{
    public static class CharacterMapper
    {
        public static Core.Character.Character ToCore(this Character dal)
        {
            return new Core.Character.Character();
            {

            };
        }

        public static Character ToDal(this Core.Character.Character core)
        {
            return new Character()
            {

            };
        }
    }
}
