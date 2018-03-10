using System;

namespace Problem18_DiffIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte < byte < short < ushort < int < uint < long
            string text = "";
            bool istrue = false;
            string number = Console.ReadLine();
            try
            {
                sbyte num = sbyte.Parse(number);
                istrue = true;
                text = text + "* sbyte\r\n";
            }
            catch 
            {

            }
            try
            {
                byte num = byte.Parse(number);
                istrue = true;
                text = text + "* byte\r\n";
            }
            catch
            {
            }
            try
            {
                short num = short.Parse(number);
                istrue = true;
                text = text + "* short\r\n";
            }
            catch
            {
            }
            try
            {
                ushort num = ushort.Parse(number);
                istrue = true;
                text = text + "* ushort\r\n";
            }
            catch
            {
            }
            try
            {
                int num = int.Parse(number);
                istrue = true;
                text = text + "* int\r\n";
            }
            catch
            {
            }
            try
            {
                uint num = uint.Parse(number);
                istrue = true;
                text = text + "* uint\r\n";
            }
            catch
            {
            }
            try
            {
                long num = long.Parse(number);
                istrue = true;
                text = text + "* long\r\n";
            }
            catch
            {
            }
            if (istrue)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
