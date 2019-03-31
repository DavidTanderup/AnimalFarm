using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
   public class FarmsAnimals
    {
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sounds { get; set; }
        public string Aspirations { get; set; }
        public string Eats { get; set; }

        public FarmsAnimals(string species, string breed, string name, string color, 
                            string sounds, string aspirations, string eats)
        {
            Species = species;
            Breed = breed;
            Name = name;
            Color = color;
            Sounds = sounds;
            Aspirations = aspirations;
            Eats = eats;

        }

    }
}
