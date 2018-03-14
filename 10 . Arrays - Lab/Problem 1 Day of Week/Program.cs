using System;

namespace Problem_1_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string [] dayInEnglish = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (num<1 || num>7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(dayInEnglish[num - 1]);
            }
            
        }
    }
}
