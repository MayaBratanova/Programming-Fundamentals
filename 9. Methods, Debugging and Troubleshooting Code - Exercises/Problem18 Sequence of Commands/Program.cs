using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();
        string line = Console.ReadLine();
        

        while (!line.Equals("stop"))
        {
            string[] command = line.Split(' ').ToArray();
            //string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command[0].Equals("add") ||
                command[0].Equals("subtract") ||
                command[0].Equals("multiply"))
            {
                //string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);
            }
            else if (command[0].Equals("lshift") || command[0].Equals("rshift"))
            {
                PerformAction(array, command, args);
            }

                long[]result = PerformAction(array, command, args);
                PrintArray(result);
                array = result;
                
            
           

           //PerformAction(array, command, args);
           //PrintArray(array);
           // Console.WriteLine('\n');
            line = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string[] action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0]-1;
        int value = args[1];

        switch (action[0])
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
        return array;
    }

     static long[] ArrayShiftRight(long[] array)
    {
        long a = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = a;
        return array;
    }

     static long[] ArrayShiftLeft(long[] array)
    {
        long a = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = a;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
