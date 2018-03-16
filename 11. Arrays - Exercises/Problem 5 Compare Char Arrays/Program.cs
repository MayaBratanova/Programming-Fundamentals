using System;
using System.Linq;

namespace Problem_5_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool istrue = false;
            if (firstArray.Length<secondArray.Length)
            {
                PrintFirst(firstArray, secondArray);
            }
            else if (firstArray.Length > secondArray.Length)
            {
                PrintSecond(firstArray, secondArray);
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        istrue = true;
                        continue;
                    }
                    else if (firstArray[i] > secondArray[i])
                    {
                        PrintSecond(firstArray, secondArray);
                        istrue = false;
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        PrintFirst(firstArray, secondArray);
                        istrue = false;
                        break;
                    }
                }
            }
            if (istrue)
            {
                PrintFirst(firstArray, secondArray);
            }
        }

        static void PrintFirst(char[] firstArray, char[] secondArray)
        {
            foreach (var num in firstArray)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            foreach (var num in secondArray)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
        static void PrintSecond(char[] firstArray, char[] secondArray)
        {
            foreach (var num in secondArray)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            foreach (var num in firstArray)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
