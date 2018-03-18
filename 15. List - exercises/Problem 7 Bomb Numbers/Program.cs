using System;
using System.Linq;

namespace Problem_7_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var powerBomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = powerBomb[0];
            int power = powerBomb[1];
            while (input.Contains(bomb))
            {
                int index = input.IndexOf(bomb);
                if (index - power >= 0 && index + power <= input.Count - 1)
                {
                    input.RemoveRange(index - power, 2 * power + 1);
                }
                else if (index - power < 0 && index + power <= input.Count - 1)
                {
                    input.RemoveRange(0, index + 1 + power);
                }
                else if (index - power >= 0 && index + power > input.Count - 1)
                {
                    input.RemoveRange(index - power, power + 1+(input.Count-1)-index);
                }
                else if (index - power < 0 && power > input.Count - 1)
                {
                    input.RemoveRange(0, power + 1 + (input.Count - 1) - index);
                }

            }
            Console.WriteLine(input.Sum());
           

        }
    }
}
