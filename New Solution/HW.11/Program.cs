using System;
using HW._11.Entities;

namespace HW._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("START");

            BasicFigure[] figures = new BasicFigure[3];

            //creates random figure with random side sizes in array
            for (int i = 0; i < figures.Length; i++)    
            {
                Random rnd = new Random();
                int rndSize = rnd.Next(1, 10);
                int rndFigure = rnd.Next(1, 3);

                if (rndFigure.Equals(1))
                {
                    figures[i] = new Square("Square", rndSize);
                    Logger.Log.Info("Created SQUARE");
                }
                else if (rndFigure.Equals(2))
                {
                    figures[i] = new Circle("Circle", rndSize);
                    Logger.Log.Info("Created CIRCLE");
                }
                else
                {
                    figures[i] = new Triangle("Triangle1", rndSize);
                    Logger.Log.Info("Created TRIANGLE");
                }
            }

            Logger.Log.Info("OUTPUT");
            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"This is {figures[i].Name}, CLR Type is {figures[i]}, Area = {figures[i].GetArea()}");
            }
            Logger.Log.Info("FINISH \n");
        }
    }
}
