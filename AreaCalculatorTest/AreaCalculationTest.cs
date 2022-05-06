using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;

namespace AreaCalculatorTest
{
    [TestClass]
    public class AreaCalculationTest
    {
        IAreaCalculation triangeleArea = new TriangleArea();
        IAreaCalculation circleArea = new CircleArea();

        [TestMethod]
        public void TriangleAreaTest()
        {
            double[] sides = { 4.0, 5.0, 6.4031242374328486864882176746218 };

            double expected = 10;
            double actual = triangeleArea.GetArea(sides);

            Assert.AreEqual(expected, actual, "Expected and actual are not equal.");
        }

        [TestMethod]
        public void RectangleAreaTest()
        {
            IAreaCalculation rectangleArea = new RectangleArea();
            double expected = 25;
            double actual = rectangleArea.GetArea(5.0, 5.0);
            
            Assert.AreEqual(expected, actual, "Expected and actual are not equal.");  
        }
        
        [TestMethod]
        public void CircleAreaTest()
        {
            double expected = 201.06;
            double actual = circleArea.GetArea(8);

            Assert.AreEqual(expected, actual, 0.01, "Expected and actual are not equal.");
        }
    }
}

public class RectangleArea : IAreaCalculation
{
    double IAreaCalculation.GetArea(params double[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Invalid arguments count for rectangle area calculation.");
            return 0.0;
        }
        if (args[0] < 0 || args[1] < 0)
        {
            Console.WriteLine("Rectangle's side length cannot be negative"); //TODO : Must be replaced to Exceptions
            return 0;
        }
        return args[0] * args[1];
    }
}
