using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    class Passenger
    {
        public string Name { get; set; }
        internal string Passport { get; set; }
        internal int Ticket { get; set; }
        internal int Luggage { get; set; }
        internal int HandLuggage{ get; set; }
    }
}
