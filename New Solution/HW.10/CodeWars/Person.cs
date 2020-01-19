using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10.CodeWars
{
    // Link - https://www.codewars.com/kata/55a144eff5124e546400005a/solutions/csharp

    //Your task is to complete this Class, the Person class has been created. You must fill in the Constructor 
    //method to accept a name as string and an age as number,complete the get Info property
    //and getInfo method/Info getter which should return "johns age is 34"

    public class Person
    {
        public string Info { get; set; }
        public Person(string name, int age)
        {
            Info = $"{name}s age is {age}";
        }
    }
}
