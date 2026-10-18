namespace Labb7.RanCharacter
{
    internal class CharacterManager
    {
      readonly List<Character> characterList = DataReader.Load<Character>("Character.json");

        public void ViewAllCharacters()
        {
            Console.Clear();
            if (characterList.Count < 1)
            {
                Console.WriteLine("No characters saved yet");
            }
            else
            {
                foreach (var character in characterList)
                {
                    Console.WriteLine(character);
                }
            }
            
        }
        public void SaveCharacter(Character newCharacter)
        {
          characterList.Add(newCharacter);
            DataReader.Save(characterList, "Character.json");
        }


    }
}
