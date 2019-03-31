using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class AnnabellesWish
    {
        /// The cows on this farm are decendants of Annabelle, the only cow who ever had a place on Santa's team. The cows are very charitable and kind, but the horses
        /// feel like the cows get taken advantage of and milked for all they are worth. All the cows share the same dream of flying, although they frown about the tall tales
        /// of a cow jumping over the moon. Cows still need oxygen to breathe and it's not like anyone is inventing cow shaped spacesuits. Besides even if they wanted to make suits themselves
        /// which they don't...they would be the first to point out they don't have opposable thumbs. No thumbs no space suits.
        public string[] Annabelle(string name)
        {
            FarmsAnimals cow = new FarmsAnimals("Cow", "Jersy", name, "Brown", "Moo", "To fly or jump over the moon", "Grass...or hay. Mostly grass.");

            string[] notAReindeer = new string[] { cow.Species, cow.Breed, cow.Name, cow.Color, cow.Sounds, cow.Aspirations, cow.Eats };
            return notAReindeer;
        }
    }
}
