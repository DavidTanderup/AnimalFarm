using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class MyLittlePony
    {

        /// The horse is a sensible species that cares deeply about where their food comes from and not just looking for the big box cheapest
        /// thing that they can find to eat. Horses think of themselves more in the terms of being global citizens. Due to their selective dietary 
        /// preferences and the sound they make the other animals tend to think of them as contrarians.
        public string[] myLittlePony (string name, string breed, string color, string aspirations)
        {
            FarmsAnimals horse = new FarmsAnimals("Horse", breed, name, color, "Neigh!", aspirations, "Locally sourced non-GMO clover");

            string[] myHorse = new string[] {horse.Species,horse.Breed,horse.Name,horse.Color,horse.Sounds,horse.Aspirations,horse.Eats};
            return myHorse;
        }
      

    }
}
