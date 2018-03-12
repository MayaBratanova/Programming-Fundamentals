using System;
using System.Collections.Generic;
using System.Text;

namespace Problem12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            SymetricNum(endNum);
           
            
        }

        static void SymetricNum(int endNum)
        {
            var helper = new StringBuilder();
            var collection = new List<int>();
            int newNum = 0;
            int num = 0;
            for (int i = 10; i <= endNum; i++)
            {
                newNum = i;
                while (newNum > 0)
                {
                    helper.Append(newNum % 10);
                    newNum = newNum / 10;
                }
                num = Convert.ToInt32(helper.ToString());
                if (num == i)
                {
                    collection.Add(i);
                }
                else
                {
                    helper.Clear();
                    newNum = 0;
                    num = 0;
                    continue;

                }
                helper.Clear();
                newNum = 0;
                num = 0;
            }

            GetDigitDivideBy7(collection);
        }

        static void GetDigitDivideBy7(List<int> collection)
        {
            var collection1 = new List<int>();
            foreach (var nums in collection)
            {
                int sum = 0;
                int currentNum = nums;
                while (currentNum > 0)
                {
                    int numDivide = currentNum % 10;
                    sum = sum + numDivide;
                    currentNum = currentNum / 10;
                }
                if (sum % 7 == 0)
                {
                    collection1.Add(nums);
                }
            }
            GetEvenDigit(collection1);
        }

        static void GetEvenDigit(List<int> collection1)
        {
            var answer = new List<int>();
            foreach (var symbol in collection1)
            {
                int lastNum = symbol;
                while (lastNum > 0)
                {
                    int answerNum = lastNum % 10;
                    if (answerNum % 2 == 0)
                    {
                        answer.Add(symbol);
                        break;
                    }
                    lastNum = lastNum / 10;

                }
            }
            foreach (var m in answer)
            {
                Console.WriteLine(m);
            }
        }
    }
}
