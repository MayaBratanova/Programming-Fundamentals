using System;

namespace Problem_5_Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            length = length *100;
            if (length%width == 0 || width==0)
            {
                Console.WriteLine($"{length* width:f2}");
            }
            else
            {
                Console.WriteLine($"{(length/ width)*100:f2}%");  
            }
        }
    }
}
