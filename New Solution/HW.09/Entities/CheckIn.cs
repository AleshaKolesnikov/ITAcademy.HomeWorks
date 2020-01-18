using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class CheckIn
    {
        public void Process(Passenger passenger)
        {
            Console.WriteLine($"\n{passenger.Name}, You're in Check-in zone, please enter your passport data:");
            passenger.Passport = Console.ReadLine();

            Console.WriteLine($"{passenger.Name}, Let's weight your luggage:");
            Random rnd = new Random();
            passenger.Luggage = rnd.Next(1, 25);
            Console.WriteLine($"Your luggage weight - {passenger.Luggage}kg.");

            // Is it okey, or need I a *new Random();* for Ticket?
            passenger.Ticket = rnd.Next(1, 99);                       
            Console.WriteLine($"{passenger.Name}, here is your ticket #{passenger.Ticket}.");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
