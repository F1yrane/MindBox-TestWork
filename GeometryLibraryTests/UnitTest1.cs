namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestCircle()
        {
            var circle = new Circle(5);

            double area = Shape.CalculateArea(circle);

            Assert.AreEqual(Math.PI * 25, area, 0.0001);
        }

        [TestMethod]
        public void TestTriangle() 
        {
            var triangle = new Triangle(3, 4, 5);

            double area = Shape.CalculateArea(triangle);

            Assert.AreEqual(6, area, 0.0001);
        }

        [TestMethod]
        public void TestRightTriangle() 
        {
            var triangle = new Triangle(3, 4, 5);

            bool isRight = triangle.IsRight();

            Assert.IsTrue(isRight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTriangle()
        {
            var triangle = new Triangle(1, 1, 3);
        }

        [TestMethod]
        public void TestRectangle()
        {
            var rectangle = new Rectangle(4, 5);

            double area = Shape.CalculateArea(rectangle);

            Assert.AreEqual(20, area, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleWithNegativeSide()
        {
            var rectangle = new Rectangle(4, -1);
        }
    }
}