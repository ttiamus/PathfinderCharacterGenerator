using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponDamageTypes.CreateWeaponDamageType
{
    public class CreateWeaponDamageTypeRepository : ICommandRepository<CreateWeaponDamageTypeRequest>
    {
        public Task<Result> SaveChanges(CreateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}