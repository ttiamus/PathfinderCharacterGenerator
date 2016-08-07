using Core.Races.Requests;

namespace Core.Races
{
    public static class RaceExtensions
    {
        public static bool Validate(this GetRaceRequest race)
        {
            return race.Id != null;
        }

        public static bool Validate(this InsertRaceRequest race)
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