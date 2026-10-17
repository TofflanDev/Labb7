using Labb7.Claude;
using Labb7.GPT;
using System.Text.Json;
namespace Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HangMan.Game();

            List<string> randomNames = DataReader.Load<string>("RandomNames.json");
            List<Character> premadeCharacters = DataReader.Load<Character>("Character.json");

            Character a = new();
            Character b = new();

            //a.myCharacterData.Name = "Hero 1";
            //a.myCharacterData.Ability = "Ability";
            //a.myCharacterData.Strength = 1;
            //a.myCharacterData.Dexterity = 5;
            //a.myCharacterData.HealthPoints = 10;

            //a.myCharacterData.HealthPoints -= 1;

            //b.myCharacterData.Name = "Hero 2";
            //b.myCharacterData.Ability = "Abiaaality";
            //b.myCharacterData.Strength = 13;
            //b.myCharacterData.Dexterity = 53;
            //b.myCharacterData.HealthPoints = 110;

            //list.Add(b);
            //list.Add(a);

            foreach (Character c in premadeCharacters)
            {
                Console.WriteLine(c);
            }
            //DataReader.Save(list, "Character.json");

            //DataReader.Save(a.myCharacterData, "Character.json");
            //DataReader.Save(b.myCharacterData, "Character.json");


        }
    }
}
