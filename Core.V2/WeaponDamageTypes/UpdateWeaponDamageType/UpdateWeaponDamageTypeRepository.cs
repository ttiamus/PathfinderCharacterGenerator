﻿using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.WeaponDamageTypes.UpdateWeaponDamageType
{
    public class UpdateWeaponDamageTypeRepository : ICommandHandler<UpdateWeaponDamageTypeRequest>
    {
        public void Validate(UpdateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task Execute(UpdateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}