using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadLines();
        }

        public static void ReadLines()
        {
            
            try
            {
                int numOfLines = File.ReadAllLines(@"C:\my-file.txt").Length;
                Console.WriteLine(numOfLines.ToString());
                Console.ReadLine();
               
            }
            catch (Exception e)
            {
                int x = 0;
                Console.WriteLine(x.ToString());
            }
            Console.ReadLine();
        }
    }
}
