using System;

namespace HW._06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 10);
            }

            Console.WriteLine("Введите десять чисел");
            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                int nums = Convert.ToInt32(Console.ReadLine());
                array2[i] = nums;
            }

            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }

            Console.WriteLine("Первый массив:");
            foreach (int nums1 in array1)
            {
                Console.Write("{0},",nums1);
            }

            Console.WriteLine("\nВторой массив:");
            foreach (int nums2 in array2)
            {
                Console.Write("{0},", nums2);
            }

            Console.WriteLine("\nТретий массив:");
            foreach (int nums3 in array3)
            {
                Console.Write("{0},", nums3);
            }
        }
    }
}
