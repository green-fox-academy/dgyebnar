
using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Cars
    {
        public int GasAmount;
        public int Capacity;

        public Cars(int gas = 0, int cap = 100)
        {
            this.GasAmount = gas;
            this.Capacity = cap;
           
        }
    }
}
