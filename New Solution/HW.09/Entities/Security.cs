using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class Security
    {
        const int _maxHLWeight = 5;
        public void Process(Passenger passenger)
        {
            Console.WriteLine($"{passenger.Name}, you're in Security zone.");
            Random rnd = new Random();
            passenger.HandLuggage += rnd.Next(1, 3);

            if (passenger.HandLuggage > _maxHLWeight)
            {
                Console.WriteLine($"Your handluggage - {passenger.HandLuggage}kg. It's to big. " +
                                      $"Need to build a ziggurat for greater roominess. Throw away something");
                Console.WriteLine("Press any key for throw away something");
                Console.ReadKey();
                passenger.HandLuggage--;

                while (passenger.HandLuggage > _maxHLWeight)
                {
                    Console.WriteLine($"HandLuggage is {passenger.HandLuggage}kg, it's still to big. Press any key for throw away something");
                    Console.ReadKey();
                    passenger.HandLuggage--;
                }
            }

            Console.WriteLine($"{passenger.Name}, your handluggage - {passenger.HandLuggage}kg, so You can go further");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
