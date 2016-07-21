namespace Core.Races
{
    public class Race
    {
        public string Id { get; set; }
        public string Description { get; set; }
        //List Stat Bonus
        //List<AlternateRaceOption> AlternateRacials { get; set; }
        //List<FavoredClassOption> FavoredClasses { get; set; }
        public string Speed { get; set; }                               //in feet
        public string Size { get; set; }
    }
}
