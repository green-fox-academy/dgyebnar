using System;

namespace Sharpie
{

    class Sharpie
    {
        string Color;
        float Width;
        public float InkAmount;

        public Sharpie(string color, float width, float inkAmount = 100)
        {
            Color = color;
            Width = width;
            InkAmount = inkAmount;
        }

        public void Use()
        {
            int degrees = 10;
            float result = InkAmount - degrees;
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sharpie = new Sharpie("red", 3.44f);
            sharpie.Use();
            sharpie.Use();
            Console.ReadLine();
        }

    }
}
