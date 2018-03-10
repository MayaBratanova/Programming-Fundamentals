using System;

namespace Problem14_Integer_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(num, 16);
            Console.WriteLine(hexadecimal.ToUpper());
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);

        }
    }
}
