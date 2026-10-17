using Labb7.Claude;
using Labb7.GPT;

namespace Labb7
{
    internal class GameWorld
    {
        public void Start()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. HangMan\n" +
               "2. Character Creation\n" +
               "3. Exit Program");
                switch (Console.ReadLine())
                {
                    case "1":
                        HangMan.Game();
                        break;
                    case "2":
                        CharacterCreation.Game();
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
