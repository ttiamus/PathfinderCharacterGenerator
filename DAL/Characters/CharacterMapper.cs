namespace DAL.Characters
{
    public static class CharacterMapper
    {
        public static Core.Characters.Character ToCore(this Character dal)
        {
            return new Core.Characters.Character();
            {

            };
        }

        public static Character ToDal(this Core.Characters.Character core)
        {
            return new Character()
            {

            };
        }
    }
}
