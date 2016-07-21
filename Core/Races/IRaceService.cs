using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Races
{
    public interface IRaceService
    {
        Task<IEnumerable<Race>> GetRaces();
        Task<Race> GetRace(string id);
        Task<bool> InsertRace(Race race);
        Task<bool> UpdateRace(Race race);
        Task<bool> DeleteRace(string id);
    }
}
