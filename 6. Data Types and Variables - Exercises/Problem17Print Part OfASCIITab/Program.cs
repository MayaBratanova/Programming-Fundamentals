using System;

namespace Problem17Print_Part_OfASCIITab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char a = Convert.ToChar(num1);
            int num2 = int.Parse(Console.ReadLine());
            char b = Convert.ToChar(num2);
            for (char i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
