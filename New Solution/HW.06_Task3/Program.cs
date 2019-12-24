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
            Console.WriteLine("Tap any key to test myReverse Method");
            Console.ReadKey();
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
            Console.WriteLine("Operation speed of myReverse Method is:");
            Console.WriteLine("{0}h:{1}m:{2}s.{3}ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Tap any key to continue");
            Console.ReadKey();
            long[] array2 = new long[100_000_000];
            Random rnd2 = new Random();
            for(long j = 0; j < array2.Length; j++)
            {
                array2[j] = rnd2.Next();
            }
            Stopwatch timer2 = new Stopwatch();
            Console.WriteLine("Tap any key to test MS Reverse Method");
            Console.ReadKey();
            timer2.Start();
            Array.Reverse(array2);
            timer2.Stop();
            TimeSpan ts2 = timer2.Elapsed;
            Console.WriteLine("Operation speed of MS Reverse Method is:");
            Console.WriteLine("{0}h:{1}m:{2}s.{3}ms", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds);
            Console.ReadKey();


        }

    }
}
