using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11.Entities
{
    public class BasicFigure
    {
        public string Name { get; set; }

        public float SideA { get; set; }

        public BasicFigure()
        {
            Console.WriteLine("You're using default constructor");
        }
        public BasicFigure(string name)
        {
            Name = name;
        }
        public BasicFigure(string name, float sideA) : this(name)
        {
            SideA = sideA;
        }

        public virtual float GetArea() 
        {
            return SideA * SideA;
        }
    }
}
