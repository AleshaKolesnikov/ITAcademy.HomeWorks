using System;
using HW._09.Entities;

namespace HW._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger();
            //CheckIn check = new CheckIn();
            
            Greeting(passenger1);

            OnlineCheckinYesOrNo(passenger1);
        }
        static void OnlineCheckinYesOrNo(Passenger passenger)
            {
            Console.WriteLine($"{passenger.Name}, Welcome to airport \"Perhaps you'll survive\"\n" +
                                $"Did you pass \"check-in\" online? Tap \"Y\" for YES or \"N\" for NO");
        link1: char _clickedButton = Console.ReadKey(true).KeyChar;
            while (_clickedButton.ToString().ToUpper() != "Y" && _clickedButton.ToString().ToUpper() != "N")
            {
                Console.WriteLine("Please, tap \"Y'\" or \"N\"");
                goto link1;
            }

            switch (_clickedButton.ToString().ToUpper())
            {
                case "Y":
                    Console.WriteLine("Использовать метод, с уже пройденной регистрацией");
                    break;
                case "N":
                    CheckIn check = new CheckIn();
                    check.Process(passenger);
                    break;
                default:
                    Console.WriteLine("Please, tap \"Y'\" or \"N\"");
                    break;
            }
        }

        static void Greeting(Passenger passenger)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            int _hours = now.Hours;

            if (_hours >= 4 && _hours < 12)
                Console.WriteLine("Good Morning! What is your name?");
            else if (_hours >= 12 && _hours < 17)
                Console.WriteLine("Good Day! What is your name?");
            else if (_hours >= 17 && _hours < 23)
                Console.WriteLine("Good Evening! What is your name?");
            else
                Console.WriteLine("Good Night! What is your name?");

            passenger.Name = Console.ReadLine();
        }
    }
}
