using System;

namespace Problem_2_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string text = "";
            try
            {
                double num = double.Parse(number);
                text = "floating-point";
            }
            catch
            {
            }
            try
            {
                long num = long.Parse(number);
                text = "integer";
            }
            catch 
            {
            }
           
            Console.WriteLine(text);
        }
    }
}
