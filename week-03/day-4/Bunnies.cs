using System;

class Program
    {
        static void Main(string[] args)
        {
            int bunnies = 69;
            Console.WriteLine(BunnyEars(bunnies));
            Console.ReadLine();
        }
        public static int BunnyEars(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                BunnyEars(n - 1);
                return n * 2;
            }
        }
    }
}