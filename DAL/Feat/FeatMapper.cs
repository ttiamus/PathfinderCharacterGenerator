using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Feat
{
    public static class FeatMapper
    {
        public static Core.Feat.Feat ToCore(this Feat dal)
        {
            return new Core.Feat.Feat()
            {

            };
        }

        public static Feat ToDal(this Core.Feat.Feat core)
        {
            return new Feat()
            {

            };
        }
    }
}
