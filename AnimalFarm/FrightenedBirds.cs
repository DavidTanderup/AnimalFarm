using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class FrightenedBirds
    {

        /// The chickens often feel under-appreciated ever since Great Great Aunt Penny discovered that the sky was falling. The chickens work hard
        /// to keep themselves in fine form by eating as much as possible. They believe they will be rewarded by the farm family and taken to a better
        /// place called "Iron Skillet". This belief is reinforced by the fact that only the largest and healthiest chickens are taken by the farmer.
        public string[] chickenLittle(string name, string breed, string color)
        {
            FarmsAnimals chicken = new FarmsAnimals("Chicken", breed, name, color, "The sky is falling!", "To be brave.", "Wild seeds, green plants, and bugs");

            string[] tasty = new string[] { chicken.Species, chicken.Breed, chicken.Name, chicken.Color, chicken.Sounds, chicken.Aspirations, chicken.Eats };
            return tasty;
        }
    }
}
