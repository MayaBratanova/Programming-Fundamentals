using System;
using System.Linq;

namespace Problem_9_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int num = input[0];
            sum = sum + num;
            int position = 0;
            bool istrue = true;
            while (istrue)
            {
                if (position+num<=input.Length-1)
                {
                    num = input[num];
                    position = Array.IndexOf(input, num);
                    sum += num;
                    istrue = true;
                }
                else 
                {
                    if (position-num>0)
                    {
                       
                        num = input[num - 1];
                        position= Array.IndexOf(input, num);
                        sum += num;
                        istrue = true;
                    }
                    else
                    {
                        istrue = false;
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
            
           


        }
    }
}
