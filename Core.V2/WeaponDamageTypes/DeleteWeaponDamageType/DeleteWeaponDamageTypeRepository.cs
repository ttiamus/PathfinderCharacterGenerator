using System.Threading.Tasks;
using Common.Interfaces;
using Common.Results;

namespace Core.V2.WeaponDamageTypes.DeleteWeaponDamageType
{
    public class DeleteWeaponDamageTypeRepository : ICommandRepository<DeleteWeaponDamageTypeRequest>
    {
        public Task<Result> SaveChanges(DeleteWeaponDamageTypeRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}