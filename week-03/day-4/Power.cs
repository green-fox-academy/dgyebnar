using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerRecu(3, 2));
            Console.ReadLine();
        }

        public static int PowerRecu(int baseNumber, int different)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return baseNumber * powerN(baseNumber, different - 1);
            }
        }
    }
}