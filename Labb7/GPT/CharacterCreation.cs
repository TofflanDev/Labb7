namespace Labb7.GPT
{
    internal static class CharacterCreation
    {

        public static void Game()
        {
            bool loop = true;
            bool insideLoop = true;
            Console.Clear();
            CharacterManager characterManager = new CharacterManager();
            Character pendingCharacter = null;
         

            while (loop)
            {
                Console.WriteLine("1. Generate Random Character\n" +
                "2. Print all character\n" +
                "3. Return");
                switch (Console.ReadLine())
                {
                    case "1":
                        insideLoop = true;
                        while (insideLoop)
                        {
                            pendingCharacter = CharacterGenerator.GenerateRandomCharacter();

                            Console.WriteLine("1. Save 2. Try Again?");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Saved!");
                                    characterManager.SaveCharacter(pendingCharacter);
                                    insideLoop = false;
                                    break;
                                case "2":
                                    continue;
                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        characterManager.ViewAllCharacter();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
