using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11.Entities
{
    class Triangle : BasicFigure
    {
        public Triangle(string name, float side)
            : base(name, side) { }
        public override float GetArea()
        {
            return 0.433f * SideA * SideA;
        }
    }
}
