using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {

        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }
        public double Side4Length { get; set; }

        public Quadrilateral(double s1, double s2, double s3, double s4, string pColour):base(pColour)
        {
            this.Side1Length = s1;
            this.Side2Length = s2;
            this.Side3Length = s3;
            this.Side4Length = s4;
        }

        public double GetArea(double Area)
        {
            Area = Side1Length * Side2Length;
            return Area;
        }

        public double GetPerimeter(double Per)
        {
            Per = Side1Length + Side2Length + Side3Length + Side4Length;
            return Per;
        }
    }
}
