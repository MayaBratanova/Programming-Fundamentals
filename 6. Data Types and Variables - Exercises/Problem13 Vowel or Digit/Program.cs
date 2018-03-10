using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            if (a == 'a' || a == 'e' || a == 'o' || a == 'i' || a == 'u')
            {
                Console.WriteLine("vowel");
            }


            else if ((a >= '0') && (a <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}