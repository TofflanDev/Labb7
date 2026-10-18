namespace Labb7.RanCharacter
{
 
    internal class Character
    {
        // AI suggested removing the struct and turning it into properties.
        public string Name { get; set; } = "";
        public string Ability { get; set; } = "";
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int HealthPoints { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Ability: {Ability}\n" +
                $"Strength: {Strength}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"HealthPoints: {HealthPoints}\n";
        }

    }
}
