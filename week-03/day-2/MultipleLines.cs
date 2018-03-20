using System;
using System.IO;
namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberOfLine;
            string fileName;
            string word;
            Console.WriteLine();
            fileName = consoleInput("file name:");
            word = consoleInput("word:");
            numberOfLine= int.Parse(consoleInput("Lines :"));
            WriteMultipleLine(fileName, word, numberOfLine);
            
        }
        public static string consoleInput(string inputName)
        {
            Console.WriteLine(inputName);
            return Console.ReadLine();
        }
        public static void WriteMultipleLine(string fileName, string word, int numberOfLine)
        {
            try
            {
                string path = @"C:/Valami/myitem.txt;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < numberOfLine; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
            }
            finally
            {
                Console.Read();

            }
        }
    }
}