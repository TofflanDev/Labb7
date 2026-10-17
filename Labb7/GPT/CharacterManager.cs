using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7.GPT
{
    internal class CharacterManager
    {
        List<Character> characterList = DataReader.Load<Character>("Character.json");

        public void ViewAllCharacter()
        {
            Console.Clear();
            foreach (var character in characterList)
            {
                Console.WriteLine(character);
            }
        }
        public void SaveCharacter(Character newCharacter)
        {
          characterList.Add(newCharacter);
            DataReader.Save(characterList, "Character.json");
        }


    }
}
