using Core.Enum;
using MongoDB.Bson;

namespace DAL.Races
{
    public class Race
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //List Stat Bonus
        //List<AlternateRaceOption> AlternateRacials { get; set; }
        //List<FavoredClassOption> FavoredClasses { get; set; }
        public int Speed { get; set; }                               //in feet
        public CharacterSize Size { get; set; }
    }
}
