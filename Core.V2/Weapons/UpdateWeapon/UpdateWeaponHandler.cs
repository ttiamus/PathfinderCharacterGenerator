﻿using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.Weapons.UpdateWeapon
{
    public class UpdateWeaponHandler : ICommandHandler<UpdateWeaponRequest>
    {
        public void Validate(UpdateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Execute(UpdateWeaponRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}