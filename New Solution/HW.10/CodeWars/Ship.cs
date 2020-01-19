using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10.CodeWars
{
    //Link - https://www.codewars.com/kata/54fe05c4762e2e3047000add
    //You are a leader of a small pirate crew. And you have a plan. 
    //With the help of OOP you wish to make a pretty efficient system to identify ships with a heavy booty on board.
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }
        public bool IsWorthIt()
        {
            if (Draft-Crew*1.5 >= 20)
            return true;
            else return false;
        }
    }
}
