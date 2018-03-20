using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
     class Garden
    {

        public double amountOfWater { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        // private int percentage;

        

        public Garden(double amountOfWater, string name, string color)
        {
            this.amountOfWater = amountOfWater;
            this.name = name;
            this.color = color;
        }
    }
}
