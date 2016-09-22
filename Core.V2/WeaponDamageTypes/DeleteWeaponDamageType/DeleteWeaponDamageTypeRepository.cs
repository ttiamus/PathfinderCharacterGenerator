using System.Threading.Tasks;
using Common.Interfaces;

namespace Core.V2.WeaponDamageTypes.DeleteWeaponDamageType
{
    public class DeleteWeaponDamageTypeRepository : ICommandRepository<DeleteWeaponDamageTypeRequest>
    {
        public Task SaveChanges(DeleteWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}