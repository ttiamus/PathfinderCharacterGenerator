using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.V2.Armors.Models.Data;

namespace Core.V2.Armors
{
    public class ArmorService : IArmorService
    {
        public ArmorService()
        {
        }

        Task<IEnumerable<Armor>> IArmorService.GetArmors()
        {
            throw new NotImplementedException();
        }

        public Task<Armor> GetArmor(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertArmor(Armor armor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateArmor(Armor armor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteArmor(string id)
        {
            throw new NotImplementedException();
        }
    }
}
