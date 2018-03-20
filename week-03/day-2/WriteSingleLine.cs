using System;
using System.IO;
namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:/valami/my-file.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Hello");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("I can't open the file: my-file.txt");
                Console.Read();
            }
        }
    }
}