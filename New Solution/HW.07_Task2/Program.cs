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
            //Task1(inputString);
            //Task2(inputString);
            Task3(inputString);
        }
       
        static void Task1(string theString)
        {   
            string[] stringArray = theString.Split(new char[] { ' ' });
            string max = String.Empty;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max.Length)
                {
                    max = stringArray[i];
                }
            }
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
            foreach (string i in newStringArray)
            {
                Console.WriteLine(i);
            }
        }
        static void Task2(string theString)
        {
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
            string varIndex = stringArray[maxIndex];
            stringArray[maxIndex] = stringArray[minIndex];
            stringArray[minIndex] = varIndex;
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
        }
        static void Task3(string theString)
        {
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
    }
}
