using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10.CodeWars
{
    //Link - https://www.codewars.com/kata/53f0f358b9cb376eca001079

    //Create a class Ball.\
    //Ball objects should accept one argument for "ball type" when instantiated.
    //If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

    public class Ball
    {
        public string ballType { get; set; }

        public Ball(string ballType)
        {
            this.ballType = ballType; 
        }
        public Ball()
        {
            ballType = "regular";
        }
    }
}
