using System;

namespace HW._06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Console.WriteLine($"Введите {mass.Length-1} чисел");
            for (int i = 0; i < mass.Length - 1; i++)
            {
                int arraynum = Convert.ToInt32(Console.ReadLine());
                mass[i] = arraynum;
            }
            Console.WriteLine("Ваш массив сейчас выглядит так:");
            foreach (int numbers in mass)
            {
                Console.Write("{0},", numbers);
            }
            Console.WriteLine("\nВведите число");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс этого числа");
            int position = Convert.ToInt32(Console.ReadLine());
            while (position >= mass.Length)
            {
                Console.WriteLine($"Вы ввели число, превышающее длинну массива \nПожалуйста введите число, меньшее чем {mass.Length}");
                position = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = mass.Length - 1; i != position; i--)
            {
                mass[i] = mass[i - 1];
            }
            mass[position] = value1;
            Console.WriteLine("О май гад, Данила, ты что крейзи? Твой массив теперь выглядит вот так:");
            foreach (int numbers in mass)
            {
                Console.Write("{0}," , numbers);
            }
            Console.ReadKey();
        }
    }
}
