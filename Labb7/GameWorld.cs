using Labb7.HangMan;
using Labb7.RanCharacter;

namespace Labb7
{
    internal class GameWorld
    {
        public void Start()
        {
            // Claude created the entire Hangman game, so I redid the assignment and made
            // CharacterCreation instead, but decided to keep the Hangman game.
            // Check out DataReader.cs, CharacterGenerator.cs, and Character.cs.
            while (true)
            {
                Console.WriteLine("1. HangMan\n" +
               "2. Character Creation\n" +
               "3. Exit Program");
                switch (Console.ReadLine())
                {
                    case "1":
                        HangManGame.Game();
                        break;
                    case "2":
                        CharacterCreation.Game();
                        break;
                    case "3":
                        return;
                    default:
                        Console.Clear();

                        Console.WriteLine("Invalid Input");
                        break;
                }
            }

        }
    }
}
