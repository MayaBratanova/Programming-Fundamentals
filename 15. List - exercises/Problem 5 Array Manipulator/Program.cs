using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string list = "";
            while ((list = Console.ReadLine())!="print")
            {
                string[] commands = list.Split(' ').ToArray();
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int elemenet = int.Parse(commands[2]);
                    input.Insert(index, elemenet);
                }
                else if (commands[0] == "addMany")
                {
                    var helper = new List<int>();
                    int index = int.Parse(commands[1]);
                    for (int i = 2; i < commands.Length; i++)
                    {
                        helper.Add(int.Parse(commands[i]));
                    }
                    input.InsertRange(index, helper);
                }
                else if (commands[0] == "contains")
                {
                    int elemenet = int.Parse(commands[1]);
                    int result = input.IndexOf(elemenet);
                    Console.WriteLine(result);
                    // if not found result =-1;
                }
                else if (commands[0] == "remove")
                {
                    int index = int.Parse(commands[1]);
                    input.RemoveAt(index);
                }
                else if (commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]);
                    for (int i = 0; i < position; i++)
                    {
                        int firstNum = input[0];
                        for (int j = 0; j < input.Count-1; j++)
                        {
                            //1, 2, 3, 4, 5
                            input[j] = input[j + 1];
                        }
                        input[input.Count - 1] = firstNum;
                    }
                }
                else if (commands[0]=="sumPairs")
                {
                    //1, 2, 4, 5, 6, 7, 8 -> 3, 9, 13, 8
                    for (int i = 0; i < input.Count-1; i++)
                    {
                        input[i] = input[i] + input[i + 1];
                        input.RemoveAt(i + 1);

                    }

                }
            }
            Console.WriteLine("[" + string.Join(", ", input)+ "]");
        }
    }
}
