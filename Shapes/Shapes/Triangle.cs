using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {

        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }

        public Triangle(string pColour, double s1, double s2, double s3) : base(pColour)
        {
            this.Side1Length = s1;
            this.Side2Length = s2;
            this.Side3Length = s3;
        }

    }
}
