using Labb7.Claude;
using Labb7.GPT;

namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HangMan.Game();

            Character a = new();

            a.myCharacterData.myName = "Test";
            a.myCharacterData.myAbility = "Ability";
            a.myCharacterData.myStrength = 1;
            a.myCharacterData.myDexterity = 5;
            a.myCharacterData.myHealthPoints = 10;

            Console.WriteLine(a);
        }
    }
}
