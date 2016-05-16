using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Race
{
    public static class RaceMapper
    {
        public static Core.Race.Race ToCore(this Race dal)
        {
            return new Core.Race.Race()
            {

            };
        }

        public static Race ToDal(this Core.Race.Race core)
        {
            return new Race()
            {

            };
        }
    }
}
