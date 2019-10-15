using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string pColour, double Length, double Width) : base(Length, Width, Length, Width, pColour)
        {

        }


    }
}
