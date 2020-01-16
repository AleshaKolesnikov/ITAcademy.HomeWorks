using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09.Entities
{
    public class Greeting
    {
        public void Hey()
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
        }
    }
}
