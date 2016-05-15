using System;
using System.Collections.Generic;
using Core.Deity;

namespace DAL.Deity
{
    public class DeityRepository : IDeityRepository
    {
        public DeityRepository()
        {
        }

        public IEnumerable<Core.Deity.Deity> GetDeitys()
        {
            throw new NotImplementedException();
        }

        public Core.Deity.Deity GetDeity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeity(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDeity(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Deity.Deity ToCore(Deity dal)
        {
            return new Core.Deity.Deity()
            {

            };
        }

        private Deity ToDal(Core.Deity.Deity core)
        {
            return new Deity()
            {

            };
        }
    }
}
