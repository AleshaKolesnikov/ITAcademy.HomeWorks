using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11.Entities
{
    class Circle : BasicFigure
    {
        public Circle(string name, float radius)
            : base(name, radius) { }
        public override float GetArea()
        {
            return (float)Math.PI*SideA*SideA;
        }
    }
}
