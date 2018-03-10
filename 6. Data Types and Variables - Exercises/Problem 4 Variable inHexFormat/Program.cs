using System;

namespace Problem_4_Variable_inHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int decimalNum = Convert.ToInt32(num, 16);
            Console.WriteLine(decimalNum);
        }
    }
}
