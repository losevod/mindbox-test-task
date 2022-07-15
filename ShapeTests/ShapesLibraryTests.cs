using ShapesLibrary;

namespace ShapeTests
{
    [TestClass]
    public class ShapesLibraryTests
    {

        //Circle tests

        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(15);

            var circleArea = circle.CalculateArea();
            
            Assert.AreEqual(706.8583470577034, circleArea);
        }

        [TestMethod]
        public void CircleRightRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-15));
        }

        //Triangle tests

        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(5, 6, 7);

            var triangleArea = triangle.CalculateArea();

            Assert.AreEqual(14.696938456699069, triangleArea);
        }

        [TestMethod]
        public void IsNotRightTriangleTest()
        {
            var triangle = new Triangle(5, 6, 7);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.AreEqual(false, isRightTriangle);
        }
        [TestMethod]
        public void IsRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRightTriangle = triangle.IsRightTriangle();

            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        [DataRow(-1, -1, -1)]
        public void TriangleRightSidesTest(int a, int b, int c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c));
        }

    }
}