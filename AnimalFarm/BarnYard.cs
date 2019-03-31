using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class BarnYard
    {
        static void Main(string[] args)
        {
            ThingsAnimalsReallyDo things = new ThingsAnimalsReallyDo();
            FrightenedBirds Chicken = new FrightenedBirds();
            MyLittlePony Horse = new MyLittlePony();
            AnnabellesWish Cow = new AnnabellesWish();
            PorkyPig Pig = new PorkyPig();

            string[] Babe = Pig.BabeTheMostBeautfulPigEVER("Babe", "To be big like the Hulk");
            string[] Penny = Chicken.chickenLittle("Penny", "Rhode Island Red", "Black..and Red");
            string[] Princess = Horse.myLittlePony("Princess", "Falabella", "White", "Own my own food truck");
            string[] Anna = Cow.Annabelle("Anna");


            List<string[]> CoreFour = new List<string[]>() { Babe, Penny, Princess, Anna };

            foreach (var animal in CoreFour)
            {

                Console.WriteLine(things.AnimalIntroduction(animal));
                Console.WriteLine("\n");
            }



            Console.ReadLine();
        }
    }


}
