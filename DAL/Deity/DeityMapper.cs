using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Deity
{
    public static class DeityMapper
    {
        public static Core.Deity.Deity ToCore(this Deity dal)
        {
            return new Core.Deity.Deity()
            {

            };
        }

        public static Deity ToDal(this Core.Deity.Deity core)
        {
            return new Deity()
            {

            };
        }
    }
}
