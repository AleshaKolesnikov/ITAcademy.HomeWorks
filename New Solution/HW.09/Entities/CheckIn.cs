using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class CheckIn
    {
        const int _maxLuggageWeight = 20;
        public void Process(Passenger passenger)
        {
            Console.WriteLine($"\n{passenger.Name}, You're in Check-in zone, please enter your passport data:");
            passenger.Passport = Console.ReadLine();

            Console.WriteLine($"{passenger.Name}, Let's weight your luggage:");
            Random rnd = new Random();
            passenger.Luggage = rnd.Next(15, 25);

            if (passenger.Luggage > _maxLuggageWeight)
            {
                Console.WriteLine($"{passenger.Name}, your luggage is {passenger.Luggage}kg, it's to big, Transfer surplus to hand luggage.");

                Console.WriteLine("For transfering press any button.");
                Console.ReadKey();

                while (passenger.Luggage > _maxLuggageWeight)
                {
                    passenger.Luggage--;
                    passenger.HandLuggage++;
                }

                Console.WriteLine($"Now your luggage is {passenger.Luggage}kg");
            }
            else
            {
                Console.WriteLine($"Your luggage is {passenger.Luggage}kg");
            }

            passenger.Ticket = rnd.Next(1, 99);                       
            Console.WriteLine($"{passenger.Name}, here is your ticket #{passenger.Ticket}.");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
