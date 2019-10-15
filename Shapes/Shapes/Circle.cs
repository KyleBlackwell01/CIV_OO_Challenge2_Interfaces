using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape, IShapeCalc
    {
        public readonly double PI = Math.PI;
        public double Radius { get; set; }

        public Circle(string pColour, double Radius) : base(pColour)
        {
            this.Radius = Radius;
        }

        public double GetArea(double Area)
        {
            Area = PI *(Radius * Radius);
            return Area;
        }

        public double GetPerimeter(double Per)
        {
            Per = 2 * PI * Radius;
            return Per;
        }
    }
}
