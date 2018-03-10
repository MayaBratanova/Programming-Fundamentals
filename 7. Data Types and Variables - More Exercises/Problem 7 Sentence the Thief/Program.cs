using System;

namespace Problem_6_Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte”, “int” or “long”. 
            string type = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            long record = long.MinValue;

            for (int i = 1; i <= num; i++)
            {
                long number = long.Parse(Console.ReadLine());
                switch (type)
                {
                    case "sbyte":
                        if (number <= sbyte.MaxValue && number > record)
                        {
                            record = number;
                        }
                        break;
                    case "int":
                        if (number <= int.MaxValue && number > record)
                        {
                            record = number;
                        }
                        break;
                    case "long":
                        if (number <= long.MaxValue && number > record)
                        {
                            record = number;
                        }
                        break;
                    default:
                        break;

                }
            }
            //record
            long result = 0;
            if (record<0)
            {
                result = (long)(Math.Ceiling((decimal)record / -128));
            }
            else if (record>=0)
            {
                 result = (long)(Math.Ceiling((decimal)record /127));
            }
            if (result<=1)
            {
                Console.WriteLine($"Prisoner with id {record} is sentenced to {result} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {record} is sentenced to {result} years");
            }

        }
    }
}
