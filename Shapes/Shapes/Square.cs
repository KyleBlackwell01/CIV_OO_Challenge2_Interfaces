using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public Square(string pColour, double SideLength) : base(SideLength, SideLength, SideLength, SideLength, pColour)
        {

        }

    }
}
