using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Weapon
{
    public static class WeaponMapper
    {
        public static Core.Weapon.Weapon ToCore(this Weapon dal)
        {
            return new Core.Weapon.Weapon()
            {

            };
        }

        public static Weapon ToDal(this Core.Weapon.Weapon core)
        {
            return new Weapon()
            {

            };
        }
    }
}
