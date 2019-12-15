using System;

namespace HW._04_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Gamer! \nThis is tutorial for how walking.\nPlease, use buttons\"W\",\"A\",\"S\",\"D\" for walking forward, left, back and right.\nOr use button \"Q\" for quit.");
            char clickedButton = Convert.ToChar(Console.Read());
            switch (clickedButton)
            {
                case 'W':
                    Console.WriteLine("Allright - you're moving forward");
                    break;
                case 'w':
                    goto case 'W';
                case 'A':
                    Console.WriteLine("Allright - you're moving left");
                    break;
                case 'a':
                    goto case 'A';
                case 'S':
                    Console.WriteLine("Allright - you're moving back");
                    break;
                case 's':
                    goto case 'S';
                case 'D':
                    Console.WriteLine("Allright - you're moving right");
                    break;
                case 'd':
                    goto case 'D';
                case 'Q':
                    Console.WriteLine("Oh, You wanna quit. If you'll want to walking more you can use your legs.");
                    return;
                case 'q':
                    goto case 'Q';
                default:
                    Console.WriteLine("Ohhh, you're trying to fly, using unknown buttons, but you can't do this.Please, use buttons\"W\",\"A\",\"S\",\"D\" for walking");
                    break;
            }
        }
    }
}