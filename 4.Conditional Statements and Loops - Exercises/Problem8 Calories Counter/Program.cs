using System;

namespace Problem8_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string ingredians = "";
            int calory = 0;
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                ingredians = Console.ReadLine().ToLower();
                switch (ingredians)
                {
                    case "cheese": calory = 500; break;
                    case "tomato sauce": calory = 150; break;
                    case "salami": calory = 600; break;
                    case "pepper": calory = 50; break;
                    default: calory = 0;
                        break;
                }
                sum += calory;

            }
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
