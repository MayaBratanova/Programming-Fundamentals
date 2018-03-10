using System;

namespace Problem_5_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool istrue = Convert.ToBoolean(str);
            if (istrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
