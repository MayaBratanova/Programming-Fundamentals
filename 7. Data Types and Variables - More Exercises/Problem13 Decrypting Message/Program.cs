using System;
using System.Text;

namespace Problem13_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = new StringBuilder();
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                answer.Append((char)(symbol + key));
            }
            Console.WriteLine(answer);
        }
    }
}
