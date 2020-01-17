using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class CheckIn
    {
        public void Process(Passenger passenger)
        {
            Console.WriteLine($"{passenger.Name}, You're in Check-in zone, please enter your passport data:");
            passenger.Passport = Console.ReadLine();
            Random rnd = new Random();
            passenger.Ticket = rnd.Next(1, 1000);
            Console.WriteLine($"Here is your ticket,{passenger.Name}");
        }
    }
}
