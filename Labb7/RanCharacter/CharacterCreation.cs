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

        private static void CreateCharacter(CharacterManager manager)
        {
            while (true)
            {
                var character = CharacterGenerator.GenerateRandomCharacter();
                Console.Clear();
                Console.WriteLine($"Generated character:\n{character}");

                while (true)
                {
                    Console.WriteLine("1. Save  2. Try again");
                    string? choice = Console.ReadLine();

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
