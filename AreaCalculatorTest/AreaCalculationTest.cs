using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;

namespace AreaCalculatorTest
{
    [TestClass]
    public class TriangleCalculationTest
    {
        IAreaCalculation triangleArea = new TriangleArea();

        [TestMethod]
        public void AreaTest()
        {
            double[] sides = { 4.0, 5.0, 6.4031242374328486864882176746218 };

            double expected = 10;
            double actual = triangleArea.GetArea(sides);

            Assert.AreEqual(expected, actual, "Expected and actual are not equal.");
        }

        [TestMethod]
        public void ExceptionTest()   //для круга еще
        {
            double[] sides = { -4.0, 5.0, 6.4031242374328486864882176746218 };
            Action action = () => triangleArea.GetArea(sides);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void ZeroAsAgrs()
        {
            double[] sides = { 0.0, 5.0, 6.4031242374328486864882176746218 };
            
            Action action = () => triangleArea.GetArea(sides);

            Assert.ThrowsException<ArgumentException>(action);
        }

    }

    [TestClass]
    public class CircleCalculationTest
    {
        IAreaCalculation circleArea = new CircleArea();
        [TestMethod]
        public void AreaTest()
        {

            double expected = 201.06;
            double actual = circleArea.GetArea(8);

            Assert.AreEqual(expected, actual, 0.01, "Expected and actual are not equal.");
        }

        [TestMethod]
        public void ExceptionTest()
        {
            double[] radius = { -8 };
            Action action = () => circleArea.GetArea(radius);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void ZeroArgsException()
        {
            double[] radius = { };
            Action action = () => circleArea.GetArea(radius);

            Assert.ThrowsException<ArgumentException>(action);
        }

        [TestMethod]
        public void ZeroAsAgrs()
        {
            double expected = 0;
            double r = 0;
            double actual = circleArea.GetArea(r);

            Assert.AreEqual(expected, actual, "Expected and actual are not equal.");
        }
    }
}
