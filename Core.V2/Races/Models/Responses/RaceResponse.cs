using Core.V2.Enum;

namespace Core.V2.Races.Models.Responses
{
    public class RaceResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //List Stat Bonus
        //List<AlternateRaceOption> AlternateRacials { get; set; }
        //List<FavoredClassOption> FavoredClasses { get; set; }
        public int Speed { get; set; }                               //in feet
        public CharacterSize Size { get; set; }
    }
}
