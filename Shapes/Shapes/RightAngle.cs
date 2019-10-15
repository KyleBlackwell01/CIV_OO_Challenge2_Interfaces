using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle(string pColour, double s1, double s2):base (pColour, s1, s2, 0)
        {
            
        }

        public void SetHypotenuse(double s1, double s2)
        {
            Side3Length = Math.Sqrt(s1 * s1 + s2 * s2);
        }

        public double GetArea(double Area)
        {
            Area = 0.5 * Side1Length * Side2Length;
            return Area;
        }

        public double GetPerimeter(double Per)
        {
            Per = Side1Length + Side2Length + Side3Length;
            return Per;
             
        }


    }
}
