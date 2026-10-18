namespace Labb7.HangMan
{
    internal static class HangMan
    {
        // Antal fel man får göra innan gubben är klar (matchar antal steg i HangManData.Stages).
        private const int MaxWrongGuesses = 6;

        public static void Game()
        {
            Console.Clear();

            string word = HangManData.GetRandomWord();
            List<char> guessedLetters = new();
            int wrongGuesses = 0;
            string message = "Välkommen till Hänga gubben!";

            while (wrongGuesses < MaxWrongGuesses && !IsWordGuessed(word, guessedLetters))
            {
                DrawScreen(word, guessedLetters, wrongGuesses, message);

                Console.Write("Gissa en bokstav: ");
                string input = (Console.ReadLine() ?? "").Trim().ToLower();

                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    message = "Skriv en enda bokstav.";
                    continue;
                }

                char letter = input[0];

                if (guessedLetters.Contains(letter))
                {
                    message = $"Du har redan gissat '{letter}'.";
                    continue;
                }

                guessedLetters.Add(letter);

                if (word.Contains(letter))
                {
                    message = $"Rätt! '{letter}' finns i ordet.";
                }
                else
                {
                    wrongGuesses++;
                    message = $"Fel! '{letter}' finns inte i ordet.";
                }
            }

            // Slutskärm
            if (wrongGuesses >= MaxWrongGuesses)
            {
                message = $"Du förlorade! Ordet var: {word}";
            }
            else
            {
                message = "Grattis, du klarade det!";
            }

            DrawScreen(word, guessedLetters, wrongGuesses, message);
        }

        private static bool IsWordGuessed(string word, List<char> guessedLetters)
        {
            foreach (char c in word)
            {
                if (!guessedLetters.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        // Gör om "hej" till "_ e _" beroende på vilka bokstäver som gissats.
        private static string GetMaskedWord(string word, List<char> guessedLetters)
        {
            string result = "";

            foreach (char c in word)
            {
                result += guessedLetters.Contains(c) ? c : '_';
                result += " ";
            }

            return result.Trim();
        }

        // Rensar skärmen och ritar allt på nytt, så att konsolen aldrig fylls med gammal text.
        private static void DrawScreen(string word, List<char> guessedLetters, int wrongGuesses, string message)
        {
            Console.Clear();
            Console.WriteLine("=== HÄNGA GUBBEN ===");
            Console.WriteLine(HangManData.Stages[wrongGuesses]);
            Console.WriteLine();
            Console.WriteLine($"Ord: {GetMaskedWord(word, guessedLetters)}");
            Console.WriteLine($"Gissade bokstäver: {string.Join(", ", guessedLetters)}");
            Console.WriteLine($"Felgissningar: {wrongGuesses}/{MaxWrongGuesses}");
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }






}
