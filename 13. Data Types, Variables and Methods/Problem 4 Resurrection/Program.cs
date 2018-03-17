using System;

namespace Problem_4_Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountPhoenixes = int.Parse(Console.ReadLine());
            long lengthBody = 0;
            decimal width = 0;
            int lengthWing = 0;
            decimal totalYears = 0;
            for (int i = 0; i < amountPhoenixes; i++)
            {
                lengthBody = long.Parse(Console.ReadLine());
                width = decimal.Parse(Console.ReadLine());
                lengthWing = int.Parse(Console.ReadLine());
                totalYears = (lengthBody*lengthBody) * (width + 2 * lengthWing);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
