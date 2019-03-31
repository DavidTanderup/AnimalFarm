using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class ThingsAnimalsReallyDo
    {
        /// Method returns a short introduction about each animal. The script uses all of the attributes of the animal.
         
        public string AnimalIntroduction(string[] animal)
        {

            string talkingAnimal = $"Hello my name is {animal[2]}. I am a {animal[3]} {animal[1]}. My dream is {animal[5]}." +
                                   $"I usually freak people out because I'm a " +
                                   $"{animal[0]} so most people think all I should say is {animal[4]}. " +
                                   $"Oh yeah I'm suppose to tell you my favorite food.....(drum roll)...{animal[6]}";
            return talkingAnimal;
        }

        // Returns animal's name.
        public string Name(string[] animal)
        {
            string theyCallMe = animal[2];
            return theyCallMe;
        }
        // Returns animal's native noise.
        public string Speak(string[] animal)
        {
            string whatISay = animal[4];
            return whatISay;
        }
        // Returns animal's dreams...they got them from somewhere..they feel like they have always had them and they are somehow defined by them.
        public string Dreams(string[] animal)
        {
            string somedayIWantTo = animal[5];
            return somedayIWantTo;
        }
        // Returns what the animal eats.
        public string Eat( string[] animal)
        {
            string myFavoriteFood = animal[6];
            return myFavoriteFood;
        }

    }
}
