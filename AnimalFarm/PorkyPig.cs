using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class PorkyPig
    {
        /// The pigs of this farm have been graced with a rare beauty that seems to be reserved for the movies. Most of the other animals on the farm see the pigs and think to themselves
        /// 'you are much to pretty to be allowed'. The pigs like Sisyphus are curse with a never ending struggle. Their stone to push up the mountain is their weight...literally. The pigs
        /// despite their great beauty wish they were in better shape. Despite hitting the Barn Yard Gym on the daily they can never seem to defeat their love of food and their genetics.
        /// #bigboned #thisfoodtastessoooogood #round5yesplease.
        public string[] BabeTheMostBeautfulPigEVER(string name, string aspirations)
        {
            FarmsAnimals pig = new FarmsAnimals("Pig", "Pot Belly", name, "Pink", "Oink", aspirations, "Anything really...you gonna finish that?");

            string[] bigAndBeautiful = new string[] { pig.Species, pig.Breed, pig.Name, pig.Color, pig.Sounds, pig.Aspirations, pig.Eats };
            return bigAndBeautiful;
        }
    }
}
