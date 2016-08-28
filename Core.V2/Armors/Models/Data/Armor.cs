namespace Core.V2.Armors.Models.Data
{
    public class Armor
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int MaxDexBonus { get; set; }
        public int ArmorCheckPenalty { get; set; }
        public int ArcaneSpellFailure { get; set; }
        public decimal SpeedModifier { get; set; }
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public ArmorType Type { get; set; }
    }
}
