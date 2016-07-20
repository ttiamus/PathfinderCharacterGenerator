using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Character
{
    public class Character
    {
        public string Id { get; set; }

        public Race.Race Race { get; set; }
        public List<Class.Class> Classes { get; set; }
        public Stats Stats { get; set; }
        public Saves Saves { get; set; }

        public Character()
        {
            this.Race = new Race.Race();
            this.Classes = new List<Class.Class>();

            this.Stats = new Stats
            {
                Str = 10,
                Dex = 10,
                Con = 10,
                Int = 10,
                Wis = 10,
                Cha = 10
            };

            this.Saves = new Saves
            {
                Fort = 0,
                Reflex = 0,
                Will = 0
            };
        }
    }

    public class Stats
    {
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
    }

    public class Saves
    {
        public int Fort { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }

    }

    public class Armor
    {
        public int ShieldBonus { get; set; }
        public int NaturalArmorBonus { get; set; }
        public int DexArmorBonus { get; set; }
        public int DodgeBonus { get; set; }
    }
}
