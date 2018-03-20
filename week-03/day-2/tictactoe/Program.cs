using System;
using System.IO;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe("win-x.txt");
            Console.ReadLine();
        }

        public static string TicTacToe(string filename)
        {
            string result;

            try
            {
                string path = @"C:\valami\win-x.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    string s;
                    do
                    {
                        s = reader.ReadLine();
                        Console.WriteLine(s);
                    }
                    while (s != null);
                    result = "X";
                }
            }
            catch
            {
                result = "O";
            }
            
               return result;
        }
    }
}
