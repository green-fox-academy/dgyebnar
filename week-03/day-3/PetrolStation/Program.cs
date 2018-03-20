using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var trabant = new Cars();
            var station = new Station();

            station.Refill(trabant);

            Console.ReadLine();
        }
    }
}
