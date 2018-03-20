using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 69;
            Console.WriteLine(SumDigit(number));
            Console.ReadLine();
        }
        public static int SumDigit(int n)
        {
            if (n != 0)
            {
                return n % 10 + SumDig(n / 10);
            }
            else
            {
                return 0;
            }
        }
    }
}