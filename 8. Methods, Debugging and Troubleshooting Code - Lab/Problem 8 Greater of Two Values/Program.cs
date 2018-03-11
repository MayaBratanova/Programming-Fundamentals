using System;

namespace Problem_8_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input =="int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                var result = ReturnMaxInt( num1,  num2);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char num1 = char.Parse(Console.ReadLine());
                char num2 = char.Parse(Console.ReadLine());
                var result = ReturnMaxChar(num1, num2);
                Console.WriteLine(result);
            }
            else if (input == "string")
            {
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                var result = ReturnMaxString(num1, num2);
                Console.WriteLine(result);
            }
        }

        static string ReturnMaxString(string num1, string num2)
        {
            if (num1.CompareTo(num2) > 1)
            {
                return num1;
            }
            else
            {
                return num2;
            }

        }

        static char ReturnMaxChar(char num1, char num2)
        {
            if (num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static int ReturnMaxInt(int num1, int num2)
        {
            
            if (num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
