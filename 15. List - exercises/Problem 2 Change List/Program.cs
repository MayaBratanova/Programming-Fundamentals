using System;
using System.Linq;

namespace Problem_2_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string list = Console.ReadLine();
            while (list!= "Odd" && list != "Even")
            {
                string[] commands = list.Split(' ').ToArray();
                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    input.RemoveAll(x => x == element);
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    input.Insert(position,element);
                }
                list = Console.ReadLine();
            }
            if (list =="Odd")
            {
                Console.WriteLine(string.Join(" ", input.Where(x=>x%2==1)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", input.Where(x => x % 2 == 0)));
            }
            
        }
    }
}
