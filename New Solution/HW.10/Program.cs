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

            Person john = new Person("john", 34);
            Console.WriteLine($"{john.Info}");

            Ball ballRegular = new Ball();
            Ball ballSuper = new Ball("super");
            Console.WriteLine($"ballRegular.ballType - {ballRegular.ballType}\nballSuper.ballType - {ballSuper.ballType}");

            Block block = new Block(new int[] { 2, 4, 6 });
            Console.WriteLine($"{block.GetHeight()}\n{block.GetLength()}\n{block.GetWidth()}\n" +
                              $"{block.GetVolume()}\n{block.GetSurfaceArea()}");

            int[] _integerArray = new int[] { 1, 2, 3, 4, 5, 4, 2, 1, 4 };
            int[] _valuesInteger = new int[] { 1, 2, 3 };
            int[] resultArray = Kata.Remove(_integerArray, _valuesInteger);

            foreach (int i in resultArray)
            { 
                Console.WriteLine(i); 
            }
        }
    }
}
