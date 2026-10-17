

namespace Labb7
{
    internal static class HangManData
    {
        // Vi börjar med bara ett ord så att vi alltid vet det rätta ordet.
        // Lägg till fler ord här senare, så väljs ett slumpmässigt.
        private static readonly string[] Words =
        {
        "programmering"
        };

        // Index = antal felgissningar (0-6). Varje steg ritar en bit till av gubben.
        public static readonly string[] Stages =
        {
@"
  +---+
  |   |
      |
      |
      |
      |
=========",

@"
  +---+
  |   |
  O   |
      |
      |
      |
=========",

@"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",

@"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",

@"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",

@"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",

@"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
    };

        public static string GetRandomWord()
        {
            return Words[Random.Shared.Next(Words.Length)];
        }
    }
}
