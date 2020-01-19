using System;
using HW._10.CodeWars;

namespace HW._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndA = new Random();
            Random rndB = new Random();
            int draft = rndA.Next();
            int crew = rndB.Next();

            Ship ship = new Ship(draft, crew);
            Console.WriteLine(ship.IsWorthIt());

            Person john = new Person("john",34);
            Console.WriteLine($"{john.Info}"); 
        }
    }
}
