using System;
using System.Linq;
using System.Numerics;

namespace Problem_1_Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int siteNumbers = int.Parse(Console.ReadLine());
            int securityToken = int.Parse(Console.ReadLine());
            string[] input = new string[3];
            string[] helper = new string[siteNumbers];
            string webName = "";
            decimal siteVisit = 0;
            decimal price = 0;
            decimal currentLost = 0;
            decimal totalLost = 0;

            for (int i = 0; i < siteNumbers; i++)
            {
                input = Console.ReadLine().Split(' ').ToArray();
                webName = input[0];
                siteVisit = decimal.Parse(input[1]);
                price = decimal.Parse(input[2]);
                helper[i] = input[0];
                currentLost = (decimal)(siteVisit * price);
                totalLost += currentLost;
            }
            foreach (var ws in helper)
            {
                Console.WriteLine(ws);
            }
          
            Console.WriteLine($"Total Loss: {totalLost:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityToken, siteNumbers)}");
        }
    }
}
