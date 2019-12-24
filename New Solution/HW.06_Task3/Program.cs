using System;
using System.Diagnostics;

namespace HW._06_Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] array = new long[100_000_000];
            Random rnd = new Random();
            for(long i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            long index = 0;
            long last = array.Length - 1;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (index != last && index < array.Length / 2)
            {
                long value = array[index];
                array[index] = array[last];
                array[last] = value;
                index++;
                last--;
            }
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            Console.WriteLine("{0}h:{1}m:{2}s.{3}ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}
