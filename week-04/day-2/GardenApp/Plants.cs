using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Plants
    {
        public double amountOfWater { get; set; }
        public string name { get; set; }
        public string color { get; set; }

        public Plants(double amountOfWater, string name, string color)
        {
            this.amountOfWater = amountOfWater;
            this.name = name;
            this.color = color;
        }
    }
}
