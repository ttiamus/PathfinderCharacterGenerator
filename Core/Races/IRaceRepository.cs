using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Races
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetRaces();
        Task<Race> GetRace(string id);
        Task InsertRace(Race race);
        Task UpdateRace(Race race);
        Task DeleteRace(string id);
    }
}
