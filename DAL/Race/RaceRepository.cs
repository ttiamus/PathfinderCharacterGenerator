using System;
using System.Collections.Generic;
using Core.Race;

namespace DAL.Race
{
    public class RaceRepository : IRaceRepository
    {
        public RaceRepository()
        {
        }

        public IEnumerable<Core.Race.Race> GetRaces()
        {
            throw new NotImplementedException();
        }

        public Core.Race.Race GetRace(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRace(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRace(int id)
        {
            throw new NotImplementedException();
        }

        private Core.Race.Race ToCore(Race dal)
        {
            return new Core.Race.Race()
            {

            };
        }

        private Race ToDal(Core.Race.Race core)
        {
            return new Race()
            {

            };
        }
    }
}
