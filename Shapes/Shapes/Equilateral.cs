using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral(string pColour, double SideLength):base(pColour, SideLength, SideLength, SideLength)
        {

        }

        public double GetArea(double Area)
        {
            Area = (float)Math.Sqrt(3) / 4 * Side1Length * Side2Length;
            return Area;
        }

        public double GetPerimeter(double Per)
        {
            Per = Side1Length + Side2Length + Side3Length;
            return Per;
        }
    }
}
