using System;
using System.Linq;

namespace Problem_4_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool istrue = false;
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i+1; j < numArray.Length; j++)
                {
                    sum = numArray[i] + numArray[j];

                        if (numArray.Contains(sum))
                        {
                            Console.WriteLine($"{numArray[i]} + {numArray[j]} == {sum}");
                            istrue = true;
                        }
                    
                }
            }
            if (istrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
