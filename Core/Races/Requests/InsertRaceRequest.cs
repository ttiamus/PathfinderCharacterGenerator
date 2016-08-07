using Core.Enum;

namespace Core.Races.Requests
{
    public class InsertRaceRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //List Stat Bonus
        //List<AlternateRaceOption> AlternateRacials { get; set; }
        //List<FavoredClassOption> FavoredClasses { get; set; }
        public int Speed { get; set; }                               //in feet
        public CharacterSize Size { get; set; }
    }
}