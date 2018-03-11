using System;

namespace Problem_4_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DrawFigure(num);
        }

        static void DrawFigure(int num)
        {
            PrintHeader(num);
            PrintBody(num);
            PrintHeader(num);
        }

        static void PrintBody(int num)
        {
            for (int j = 1; j <= num - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i <= num - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        static void PrintHeader(int num)
        {
            Console.WriteLine(new string('-', 2*num));
        }
    }
}
