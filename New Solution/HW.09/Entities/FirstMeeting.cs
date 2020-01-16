using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class FirstMeeting
    {
        protected Passenger passenger = new Passenger() { Name = Console.ReadLine() };
        public void Process()
        {
            Console.WriteLine($"{passenger.Name}, welcome to airport \"Perhaps you'll survive\"\n" +
                                $"Did you pass \"check-in\" online? Tap \"Y\" or \"N\"");

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
                    return;
                case "N":
                    Console.WriteLine("Метод для регистрации");
                    return;
                default:
                    Console.WriteLine("Please, tap \"Y'\" or \"N\"");
                    break;
            }
        }
    }
}
