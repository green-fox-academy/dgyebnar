using System;
using System.Text;

namespace Gyakszi   
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Divide(number);
        }

        public static void Divide(int number)
        {
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
            int result = number / 10;
            Console.WriteLine(result);

                if (result == 0)
                {
                    Console.WriteLine("Fail...");
                }
           
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
             Console.ReadLine();
        }
            
        }
            
    }
}
