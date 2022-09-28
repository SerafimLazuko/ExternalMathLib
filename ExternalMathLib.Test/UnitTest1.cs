using NUnit.Framework;

namespace ExternalMathLib.Test
{
    public class Tests
    {
        private const double triangleArea = 6;
        private const double circleRadius = 3;

        IFigure triangle;
        IFigure circle;

        [SetUp]
        public void Setup()
        {
            //Arrange
            triangle = new Triangle(3, 4, 5);
            circle = new Circle(circleRadius);
        }

        [Test]
        public void ExternalMath_ExecuteTriangle_ReturnCorrect()
        {
            //Act
            var result = ExternalMath.ExecuteArea(triangle);

            //Assert
            Assert.AreEqual(triangleArea, result);
        }

        [Test]
        public void ExternalMath_IsTriangleRightAngled_ReturnTrue()
        {
            //Assert
            Assert.IsTrue(((Triangle)triangle).IsTriangleRightAngled());
        }

        [Test]
        public void ExternalMath_ExecuteCircle_ReturnCorrect()
        {
            //Act
            var result = ExternalMath.ExecuteArea(circle);
            //Assert
            Assert.AreEqual(Math.Pow(circleRadius, 2)*Math.PI, result);
        }
    }
}