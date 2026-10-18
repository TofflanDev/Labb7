namespace Labb7.RanCharacter
{
    internal static class CharacterCreation
    {

        public static void Game()
        {
            bool loop = true;
            Console.Clear();
            CharacterManager characterManager = new CharacterManager();

            while (loop)
            {
                Console.WriteLine("1. Generate Random Character\n" +
                "2. Print all character\n" +
                "3. Return");
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateCharacter(characterManager);
                        break;
                    case "2":
                        characterManager.ViewAllCharacters();
                        break;
                    case "3":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        // AI suggested creating a separate method for this, since I previously had everything inside switch case 1 above. Good suggestion.
        private static void CreateCharacter(CharacterManager manager)
        {
            // AI suggested using true instead of a bool variable since I return instead of setting it to false.
            while (true)
            {
                var character = CharacterGenerator.GenerateRandomCharacter();
                Console.Clear();
                Console.WriteLine($"Generated character:\n{character}");

                while (true)
                {
                    Console.WriteLine("1. Save  2. Try again");
                    string? choice = Console.ReadLine();
                    // AI suggested using an if statement here instead of the switch statement I had.
                    if (choice == "1")
                    {
                        manager.SaveCharacter(character);
                        Console.Clear();
                        Console.WriteLine("Saved!");
                        return;
                    }
                    if (choice == "2")
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
