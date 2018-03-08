using System;

namespace Problem9_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    sum++;

                }
                catch 
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
