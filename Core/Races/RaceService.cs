using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Races
{
    public class RaceService : IRaceService
    {
        public Task<IEnumerable<Race>> GetRaces()
        {
            throw new System.NotImplementedException();
        }

        public Task<Race> GetRace(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertRace(Race race)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateRace(Race race)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteRace(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
