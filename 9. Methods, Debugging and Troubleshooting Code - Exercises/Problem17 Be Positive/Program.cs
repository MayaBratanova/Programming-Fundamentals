using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(new string [] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new List<double>();

            for (int j = 0; j < input.Length; j++)
            {
                    double num = double.Parse(input[j]);
                    numbers.Add(num);
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                double currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else
                {
                    if (j == numbers.Count-1)
                    {
                        j++;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);
                            j++;
                            found = true;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}