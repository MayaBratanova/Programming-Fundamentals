using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var answer = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                string current = ReversedNum(input[i]);
                answer.Add(int.Parse(current));
            }

            Console.WriteLine(answer.Sum());
        }

        static string ReversedNum(string v)
        {
            char[] array = v.ToCharArray();
            array = array.Reverse().ToArray();
            string answer = string.Join("", array);
            return answer;

        }
    }
}
