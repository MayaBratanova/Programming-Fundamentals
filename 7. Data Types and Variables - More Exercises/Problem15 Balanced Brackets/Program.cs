using System;
using System.Collections.Generic;

namespace Problem15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var answer = new List<string>();
            for (int i = 1; i <= num; i++)
            {
                string input = Console.ReadLine();
               
                if (input =="(" || input ==")")
                {
                    answer.Add(input);
                }
            }
            bool istrue = false;
            
                for (int i = 1; i <= answer.Count; i++)
                {
                    if (i%2!=0 && answer[i-1] == "(")
                    {
                         istrue = true;
                    }
                    else
                    {
                         istrue = false;
                    }
                    if (i % 2 == 0 && answer[i-1] == ")")
                    {
                         istrue = true;
                    }
                    else
                    {
                          istrue = false;
                    }

                }
            if (istrue)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
           
        }
    }
}
