using System;
using System.Collections.Generic;
using Core.Weapon;

namespace DAL.Weapon
{
    public class WeaponRepository : IWeaponRepository
    {
        public WeaponRepository()
        {
        }

        public IEnumerable<Core.Weapon.Weapon> GetWeapons()
        {
            throw new NotImplementedException();
        }

        public Core.Weapon.Weapon GetWeapon(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWeapon(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteWeapon(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Weapon.Weapon ToCore(Weapon dal)
        {
            return new Core.Weapon.Weapon()
            {

            };
        }

        private Weapon ToDal(Core.Weapon.Weapon core)
        {
            return new Weapon()
            {

            };
        }
    }
}
