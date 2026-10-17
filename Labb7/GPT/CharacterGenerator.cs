using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7.GPT
{
    internal static class CharacterGenerator
    {

        public static Character GenerateRandomCharacter()
        {
            Console.Clear();
            Random rnd = new Random();
            Character tempCharacter = new Character();
            List<string> generateName = DataReader.Load<string>("RandomNames.json");
            List<string> generateAbility = DataReader.Load<string>("RandomAbilities.json");
            int nIndex = rnd.Next(generateName.Count);
            int aIndex = rnd.Next(generateAbility.Count);

            tempCharacter.myCharacterData.Name = generateName[nIndex];
            tempCharacter.myCharacterData.Ability = generateAbility[aIndex];
            tempCharacter.myCharacterData.Strength = rnd.Next(5,51);
            tempCharacter.myCharacterData.Dexterity = rnd.Next(5, 46);
            tempCharacter.myCharacterData.HealthPoints = rnd.Next(50, 101);

            Console.WriteLine($"\nGenerated Character: \n" +
                $"{tempCharacter}\n\n");
            return tempCharacter;
        }



    }
}
