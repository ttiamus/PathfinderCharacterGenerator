﻿using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Weapons.CreateWeapon
{
    public class CreateWeaponRepository : ICommandRepository<CreateWeaponRequest>
    {
        public Task SaveChanges(CreateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}