using System;

namespace HW._07_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                                 "Nulla quis cursus ipsum. Nunc maximus, erat sit amet " +
                                 "consequat aliquam, neque quam porta erat, nec lacinia.";
            Task1(inputString);
            Task2(inputString);
            Task3(inputString);
            Task4(inputString);
        }
       
        static void Task1(string theString)
        {
            Console.WriteLine("Задача №1");
            string[] stringArray = theString.Split(new char[] { ' ' });
            string max = String.Empty;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max.Length)
                {
                    max = stringArray[i];
                }
            }
            Console.WriteLine($"Самое длинное слово - {max}");
            string[] newStringArray = new string[stringArray.Length - 1];
            for (int i = 0, j = 0; i < stringArray.Length && j < newStringArray.Length; i++, j++)
            {
                if (!max.Equals(stringArray[i]))
                {
                    newStringArray[j] = stringArray[i];
                }
                else
                {
                    j--;
                }
            }
            Console.WriteLine("Было:");
            foreach (string i in stringArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\nСтало:");
            foreach (string i in newStringArray)
            {
                Console.Write($"{i} ");
            }
        }
        static void Task2(string theString)
        {
            Console.WriteLine("\n\n\nЗадача №2");
            string[] stringArray = theString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string max = String.Empty;
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max.Length)
                {
                    max = stringArray[i];
                    if (maxIndex <= i)
                    {
                        maxIndex = i;
                    }
                }
            }
            string min = stringArray[0];
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (min.Length > stringArray[i].Length)
                {
                    min = stringArray[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Самое длинное слово - {max}");
            Console.WriteLine($"Самое короткое слово - {min}");
            Console.WriteLine("Было");
            foreach (string i in stringArray)
            {
                Console.Write($"{i} ");
            }
            string varIndex = stringArray[maxIndex];
            stringArray[maxIndex] = stringArray[minIndex];
            stringArray[minIndex] = varIndex;
            Console.WriteLine("\nСтало");
            foreach (string str in stringArray)
            {
                Console.Write($"{str} ");
            }
        }
        static void Task3(string theString)
        {
            Console.WriteLine("\n\n\nЗадача №3");
            int punctCounter = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                bool check = Char.IsPunctuation(theString, i);
                if (check == true)
                {
                    punctCounter++;
                }
            }
            string[] stringArray = theString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int letterCounter = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                bool check = Char.IsLetter(theString, i);
                if (check == true)
                {
                    letterCounter++;
                }
            }
            Console.WriteLine($"Число знаков препинания - {punctCounter}");
            Console.WriteLine($"Число букв - {letterCounter}");
        }
        static void Task4(string theString)
        {
            Console.WriteLine("\n\n\nЗадача №4");
            Console.WriteLine("\nСортировка массива:\n");
            string[] stringArray = theString.Split(' ');
            int[] mass = new int[stringArray.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = stringArray[i].Length;
            }
            Array.Sort(mass, stringArray);
            Array.Reverse(stringArray);
            foreach (string i in stringArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
