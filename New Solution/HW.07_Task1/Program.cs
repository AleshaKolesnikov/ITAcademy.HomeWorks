using System;

namespace HW._07_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в одну строку, разделяя каждый переход на новую строчку символом \";\"");
            string poem = Console.ReadLine();
            Console.WriteLine("Нажмите любую клавишу для замены \"O\" на \"A\" ");
            Console.ReadKey();
            char[] splitter = { ';' };
            poem = poem.Replace("о", "а");
            poem = poem.Replace("О", "А");
            poem = poem.Replace("o", "a");
            poem = poem.Replace("O", "A");
            string[] poemForString = poem.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in poemForString)
            {
                Console.WriteLine(i);
            }
        }
    }
}
