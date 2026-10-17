using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7.GPT
{
    struct CharacterData
    {
     public string myName;
     public string myAbility;
     public int myStrength;
     public int myDexterity;
     public int myHealthPoints;


    }
    internal class Character
    {


        public Character()
        {

        }

        public CharacterData myCharacterData;



        public override string ToString()
        {
            return $"Name: {myCharacterData.myName}\n" +
                $"Ability: {myCharacterData.myAbility}\n" +
                $"Strength: {myCharacterData.myStrength}\n" +
                $"Dexterity: {myCharacterData.myDexterity}\n" +
                $"HealthPoints: {myCharacterData.myHealthPoints}\n";
        }

    }
}
