using System;
using HW._09.Entities;

namespace HW._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting time = new Greeting();
            time.Hey();
            FirstMeeting firs = new FirstMeeting();
            firs.Process();
            CheckIn check = new CheckIn();
            check.Process();
        }
    }
}
