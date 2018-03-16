using System;
using System.Linq;

namespace Problem_1_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            int minLenght = Math.Min(firstArray.Length, secondArray.Length);
            int sumRight = 0;
            int sumLeft = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sumLeft += 1;
                }
                else
                {
                    break;
                }
            }
            firstArray = firstArray.Reverse().ToArray();
            secondArray = secondArray.Reverse().ToArray();
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sumRight += 1;
                }
                else
                {
                    break;
                }
            }
            if (sumLeft>= sumRight)
            {
                Console.WriteLine(sumLeft);
            }
            else
            {
                Console.WriteLine(sumRight);
            }
        }
    }
}
