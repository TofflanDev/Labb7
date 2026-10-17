using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7.GPT
{
    struct CharacterData
    {
     public string Name { get; set; }
     public string Ability { get; set; }
     public int Strength { get; set; }
     public int Dexterity { get; set; }
     public int HealthPoints { get; set; }


    }
    internal class Character
    {
        public Character()
        {

        }

        public CharacterData myCharacterData;

        public override string ToString()
        {
            return $"Name: {myCharacterData.Name}\n" +
                $"Ability: {myCharacterData.Ability}\n" +
                $"Strength: {myCharacterData.Strength}\n" +
                $"Dexterity: {myCharacterData.Dexterity}\n" +
                $"HealthPoints: {myCharacterData.HealthPoints}\n";
        }

    }
}
