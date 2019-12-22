using System;

namespace HW._04_Task1
{
    class Program
    {
         static void Main(string[] args)
            {
                char Z = '\u005A';
                char z = '\u007A';
                for (; Z != '\u0040'; Z--)
                    Console.WriteLine($"{Z} {z--}");
            }
    }
}
