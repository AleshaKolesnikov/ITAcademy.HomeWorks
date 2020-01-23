using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11.Entities
{
    public class Square : BasicFigure
    {
        public Square(string name, float side) 
            : base(name, side) { }
        public override float GetArea()
        {
            return base.GetArea();
        }
    }
}
