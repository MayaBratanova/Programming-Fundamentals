using System;

namespace Problem14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            //aaa aac aca acc caa cac cca ccc
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i!=c && j!=c && k!=c)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                        
                    }
                }
            }
        }
    }
}
