using System;

namespace Problem14_Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            string input = "";
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <=num; i++)
            {
                input = Console.ReadLine();
                if (input == "UPGRADE")
                {
                    firstBoat =(char)( firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else
                {
                    if (i%2!=0)
                    {
                        sumOdd = sumOdd + input.Length;
                    }
                    else
                    {
                        sumEven = sumEven + input.Length;
                    }
                    if (sumOdd >= 50)
                    {
                        Console.WriteLine(firstBoat);
                        break;
                    }
                    if (sumEven >= 50)
                    {
                        Console.WriteLine(secondBoat);
                        break;
                    }
                }
            }
            if (sumOdd<50 && sumEven<50)
            {
                if (sumEven < sumOdd)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }
            
        }
    }
}
