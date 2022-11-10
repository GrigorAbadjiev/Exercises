using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read n       
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            double average = sum / n;
            Console.WriteLine($"{average:f2}");
            // sum
            // average sum / n
        }
        // input // output
        // 4            
        // 95         54.25
        // 23
        // 76
        // 23
    }
}
