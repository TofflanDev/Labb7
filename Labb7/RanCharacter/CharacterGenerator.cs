namespace Labb7.RanCharacter
{
    internal static class CharacterGenerator
    {
        // AI suggested using member variables.
        private const int MinStrength = 35, MaxStrength = 50;
        private const int MinDexterity = 15, MaxDexterity = 35;
        private const int MinHealth = 50, MaxHealth = 200;

        private static List<string> Names = DataReader.Load<string>("RandomNames.json");
        private static List<string> Abilities = DataReader.Load<string>("RandomAbilities.json");


        // AI TIP: Previously, I had all the member variables inside the method and
        // also used magic numbers when generating random stats for the character.
        // AI also suggested returning a new Character directly instead of creating a temporary Character object.
        public static Character GenerateRandomCharacter()
        {
            // AI tip: Suggested using Random.Shared instead of creating a new Random().
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
