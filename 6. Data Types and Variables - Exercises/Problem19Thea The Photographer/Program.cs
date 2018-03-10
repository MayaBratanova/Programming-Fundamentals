using System;

namespace Problem19Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine())/100;
            long uploadTime = long.Parse(Console.ReadLine());
            long timeForFilter = (numberOfPictures * filterTime);
            long numberOfFilterPic = (long)Math.Ceiling(numberOfPictures * filterFactor);
            long timeForUpload = numberOfFilterPic * uploadTime ;
            long finalTime = timeForFilter + timeForUpload;
            long sec = finalTime % 60;
            finalTime = finalTime / 60;
            long min = finalTime % 60;
            finalTime = finalTime / 60;
            long hours = finalTime % 24;
            long days = finalTime / 24;
            Console.WriteLine($"{days}:{hours:d2}:{min:d2}:{sec:d2}");



        }
    }
}
