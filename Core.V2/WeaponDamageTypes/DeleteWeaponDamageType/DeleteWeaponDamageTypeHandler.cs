using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponDamageTypes.DeleteWeaponDamageType
{
    public class DeleteWeaponDamageTypeHandler : ICommandHandler<DeleteWeaponDamageTypeRequest>
    {
        public Task<bool> Validate(DeleteWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> Execute(DeleteWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}