using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        int GasAmount;

        public Station(int gas = 1000)
        {
            this.GasAmount = gas;
        }



        public void Refill(Cars cars)
        {
            GasAmount -= cars.Capacity;

            Console.WriteLine(GasAmount);
        }
    }
}
