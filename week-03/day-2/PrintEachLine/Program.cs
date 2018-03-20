using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\valami\my-file.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    string s;
                    do
                    {
                        s = reader.ReadLine();
                        Console.WriteLine(s);
                    }
                    while (s != null);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("I can't open the file");
            }
           

            Console.ReadLine();
        }
    }
}
