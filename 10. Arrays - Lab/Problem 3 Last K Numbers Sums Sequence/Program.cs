using System;

namespace Problem_3_Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 1 2 3 5 8 13 21
            // 8 2
            int countNum = int.Parse(Console.ReadLine());
            int sumNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] numArray = new int[countNum];
            numArray[0] = 1;
            for (int i = 1; i < countNum; i++)
            {
               
                for (int k = 1; k <= sumNum; k++)
                {
                    if (i-k<0)
                    {
                        continue;
                    }
                    sum = sum + numArray[i - k];
                }
                numArray[i] = sum;
                sum = 0;
            }
            Console.Write(string.Join(" ", numArray));
        }
    }
}
