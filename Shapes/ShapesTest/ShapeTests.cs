using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTest
{
    [TestFixture]
    public class ShapeTests
    {

        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
        RightAngle ra1 { get; set; }
        Equilateral eq1 { get; set; }
        Circle cir1 { get; set; }

        
        [SetUp]
        public void Init()
        {

        }

        [Test]
        [TestCase ("Blue",5,25,20)]
        [TestCase ("Blue",15,225,60)]
        [TestCase ("Blue",7,49,28)]
        public void SquareTests(string color, double s1, double expArea, double expPer)
        {
            sq1 = new Square(color, s1);

            Assert.AreEqual(expArea, sq1.GetArea(s1));
            Assert.AreEqual(expPer, sq1.GetPerimeter(s1));
        }

        [Test]
        [TestCase ("Blue",5,10,50,30)]
        [TestCase ("Blue",4,6,24,20)]
        [TestCase ("Blue",9,7,63,32)]
        public void RectangleTests(string color, double s1, double s2, double expArea, double expPer)
        {
            rec1 = new Rectangle(color, s1, s2);

            Assert.AreEqual(expArea, rec1.GetArea(s1));
            Assert.AreEqual(expPer, rec1.GetPerimeter(s1));
        }

        [Test]
        [TestCase ("Blue",5, 10.83, 15)]
        [TestCase("Blue", 15, 97.43, 45)]
        [TestCase("Blue", 7, 21.22, 21)]
        public void EquilateralTests(string color, double s1, double expArea, double expPer)
        {
            eq1 = new Equilateral(color, s1);

            Assert.AreEqual(expArea, Math.Round(eq1.GetArea(s1), 2));
            Assert.AreEqual(expPer, Math.Round(eq1.GetPerimeter(s1)));
        }

        [Test]
        [TestCase ("Blue",5, 10, 25, 26.18)]
        [TestCase("Blue", 4, 6, 12, 17.21)]
        [TestCase("Blue", 9, 7, 31.5, 27.4)]
        public void RightAngleTests(string color, double s1, double s2, double expArea, double expPer)
        {
            ra1 = new RightAngle(color, s1, s2);
            ra1.SetHypotenuse(s1, s2);
            
            Assert.AreEqual(Math.Round(expArea), Math.Round(ra1.GetArea(s1)));
            Assert.AreEqual(Math.Round(expPer), Math.Round(ra1.GetPerimeter(s1)));
        }

        [Test]
        [TestCase ("Blue", 5, 78.54, 31.42)]
        [TestCase("Blue", 15, 706.86, 94.25)]
        [TestCase("Blue", 7, 153.94, 43.98)]
        public void CircleTests(string color, double s1, double expArea, double expPer)
        {
            cir1 = new Circle(color, s1);

            Assert.AreEqual(expArea, Math.Round(cir1.GetArea(s1), 2));
            Assert.AreEqual(expPer, Math.Round(cir1.GetPerimeter(s1), 2));

        }


    }
}
