namespace DAL.Armor
{
    public static class ArmorMapper
    {
       public static Core.Armor.Armor ToCore(this Armor dal)
        {
            return new Core.Armor.Armor()
            {

            };
        }

        public static Armor ToDal(this Core.Armor.Armor core)
        {
            return new Armor()
            {

            };
        }
    }
}
