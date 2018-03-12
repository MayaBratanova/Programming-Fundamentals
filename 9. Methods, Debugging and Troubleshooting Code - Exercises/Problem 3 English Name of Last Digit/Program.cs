using System;

namespace Problem_3_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = (Console.ReadLine());
            string answer = PrintLastDigitEnglish(num);
            Console.WriteLine(answer);
        }

        static string PrintLastDigitEnglish(string number)
        {
            var lastDigit = number[number.Length-1];
            string text = "";
            switch (lastDigit)
            {
                case '1': text = "one"; break;
                case '2': text = "two"; break;
                case '3': text = "three"; break;
                case '4': text = "four"; break;
                case '5': text = "five"; break;
                case '6': text = "six"; break;
                case '7': text = "seven"; break;
                case '8': text = "eight"; break;
                case '9': text = "nine"; break;
                case '0': text = "zero"; break;
            }
            return text;
        }
    }
}
