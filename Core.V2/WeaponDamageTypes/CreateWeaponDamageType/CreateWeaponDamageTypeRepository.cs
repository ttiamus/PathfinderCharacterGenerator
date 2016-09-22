using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.WeaponDamageTypes.CreateWeaponDamageType
{
    public class CreateWeaponDamageTypeRepository : ICommandRepository<CreateWeaponDamageTypeRequest>
    {
        public Task SaveChanges(CreateWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}