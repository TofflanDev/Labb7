namespace Labb7.RanCharacter
{
    internal static class CharacterGenerator
    {
        private const int MinStrength = 35, MaxStrength = 50;
        private const int MinDexterity = 15, MaxDexterity = 35;
        private const int MinHealth = 50, MaxHealth = 200;

        private static List<string> Names = DataReader.Load<string>("RandomNames.json");
        private static List<string> Abilities = DataReader.Load<string>("RandomAbilities.json");



        public static Character GenerateRandomCharacter()
        {
            Random rnd = Random.Shared;

            return new Character
            {
                Name = Names[rnd.Next(Names.Count)],
                Ability = Abilities[rnd.Next(Abilities.Count)],
                Strength = rnd.Next(MinStrength, MaxStrength + 1),
                Dexterity = rnd.Next(MinDexterity, MaxDexterity + 1),
                HealthPoints = rnd.Next(MinHealth, MaxHealth + 1)
            };
        }



    }
}
