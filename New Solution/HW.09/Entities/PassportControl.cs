using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class PassportControl
    {
        public void Process(Passenger passenger)
        {
            Console.WriteLine($"{passenger.Name}, let's check your data.");
            Console.WriteLine($"Your NAME is {passenger.Name}, your PASSPORT is {passenger.Passport} " +
                $"your TICKET is #{passenger.Ticket}");
            if (passenger.Ticket % 3 == 0)
            {
                Console.WriteLine($"{passenger.Name} You are lucky one, you have window seat.");
            }
            Console.WriteLine("Have a safe flight");
        }
    }
}
