using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponDamageTypes.UpdateWeaponDamageType
{
    public class UpdateWeaponDamageTypeHandler : ICommandHandler<UpdateWeaponDamageTypeRequest>
    {
        public Task<bool> Validate(UpdateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(UpdateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}