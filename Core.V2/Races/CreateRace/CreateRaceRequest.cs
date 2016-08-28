using Core.V2.Characters;

namespace Core.V2.Races.CreateRace
{
    public class CreateRaceRequest
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