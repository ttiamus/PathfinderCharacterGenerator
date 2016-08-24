using Core.V2.Races.CreateRace;
using Core.V2.Races.DeleteRace;
using Core.V2.Races.GetRace;
using Core.V2.Races.UpdateRace;

namespace Core.V2.Races
{
    public static class RaceExtensions
    {
        public static bool Validate(this GetRaceRequest race)
        {
            return race.Id != null;
        }

        public static bool Validate(this CreateRaceRequest race)
        {
            return !string.IsNullOrWhiteSpace(race.Name)
                && !string.IsNullOrWhiteSpace(race.Description);
        }

        public static bool Validate(this UpdateRaceRequest race)
        {
            return race.Id != null
                && !string.IsNullOrWhiteSpace(race.Name)
                && !string.IsNullOrWhiteSpace(race.Description);
        }

        public static bool Validate(this DeleteRaceRequest race)
        {
            return race.Id != null;
        }
    }
}