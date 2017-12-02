using System;
using System.Diagnostics;
using static System.Console;

namespace AlgorithmsPrinceton
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            int size = 1000;
            int[] array = new int[size];

         
            for (int i = 0; i < size; i++) // fillin
            {
                array[i] = random.Next(-1000000000,1000000000);
            }

            //foreach (var item in array)
            //{
            //    WriteLine(item);
            //}

            stopwatch.Start(); // start time evaluation
            int counts = ThreeSum.Count(array);
            stopwatch.Stop(); // end time eveluation

            TimeSpan time = stopwatch.Elapsed;

            WriteLine($"Time of calculation: {time} " +
                $"\nNumber of counts:{counts}");

            ReadLine();
        }
    }
}
