using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plants flower1 = new Plants(0, "flower", "yellow");
            Plants flower2 = new Plants(0, "flower", "blue");
            Plants tree1 = new Plants(0, "tree", "orange");
            Plants tree2 = new Plants(0, "tree", "purple");

            List<Plants> plants = new List<Plants>()
            {
                flower1,
                flower2,
                tree1,
                tree2
            };
            watering(plants);
            Console.ReadLine();
        }
        public static void watering(List<Plants> plant)
        {
            int divider = plant.Count;
            double water = 0;
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            water = 0;
                            break;
                        case 1: water = 40;
                            Console.WriteLine("\nwatering the plant with {0} amount of water\n", water);
                            break;
                        case 2:water = 70;
                            Console.WriteLine("\nwatering the plant with {0} amount of water\n", water);
                            break;
                    }
               
                    foreach (var item in plant)
                    {
                        if (item.name.Equals("flower"))
                        {
                            if (item.amountOfWater < 5)
                            {
                                item.amountOfWater += (water / divider) * 0.75;
                                Console.WriteLine("The {0} {1} needs water", item.color, item.name);
                            }
                            else if (item.amountOfWater > 5)
                            {
                                Console.WriteLine("The {0} {1} doesn't need water", item.color, item.name);
                            }
                        }
                        else if (item.name.Equals("tree"))
                        {
                            if (item.amountOfWater < 10)
                            {
                                item.amountOfWater += (water / divider) * 0.4;
                                Console.WriteLine("The {0} {1} needs water", item.color, item.name);
                            }
                            else if (item.amountOfWater > 5)
                            {
                                Console.WriteLine("The {0} {1} doesn't need water", item.color, item.name);
                            }
                        }
                    }
                
                }
        }
    }
}
