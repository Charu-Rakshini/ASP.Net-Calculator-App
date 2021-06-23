using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1,2)]
        [DataRow(4,7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddTwoPositiveNumbersShouldGivePositiveNumber(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 1;
            //double right = 2;
            double result = Calculator.CalculatorClass.add(left,right);
            //Assert.AreEqual(3d, result);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(-1, -2)]
        [DataRow(-4, -7)]
        [DataRow(-2, -51)]
        [DataRow(-102, -913)]
        public void AddTwoNegativeNumbersShouldGiveNegativeNumbers(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = -1;
            //double right = -2;
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddTwoDoublesShouldGiveDoubles(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 1;
            //double right = 2;
            object result = Calculator.CalculatorClass.add(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        [TestCategory("Division")]
        [TestCategory("Exception")]
        [DataRow(1, 0)]
        [DataRow(-4, 0)]
        [DataRow(2, 0)]
        [DataRow(87, 0)]
        public void DivideByZeroShouldResultInAnException(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 10;
            //double right = 0;
           
            Assert.ThrowsException<DivideByZeroException>(()=>Calculator.CalculatorClass.divide(left, right));
            

        }

        [TestMethod]
        [TestCategory("Division")]
        [DataRow(16, -2)]
        [DataRow(464, -7)]
        [DataRow(27, -51)]
        [DataRow(8789100, -913)]
        public void DividePositiveByNegativeNumberShouldGiveNegativeNumber(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 10;
            //double right = -2;

            double result = Calculator.CalculatorClass.divide(left, right);
            Assert.IsTrue(result < 0);

        }

        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddingTwoNumberShouldFollowAssociativeProperty(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 5;
            //double right = 10;

            double result1 = Calculator.CalculatorClass.add(left, right);
            double result2 = Calculator.CalculatorClass.add(right, left);
            Assert.IsTrue(result1==result2);

        }

        [TestMethod]
        [TestCategory("Multiplication")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void MultiplyingTwoNumberShouldFollowAssociativeProperty(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 5;
            //double right = 10;

            double result1 = Calculator.CalculatorClass.multiply(left, right);
            double result2 = Calculator.CalculatorClass.multiply(right, left);
            Assert.IsTrue(result1 == result2);

        }

        [TestMethod]
        [TestCategory("Division")]
        [TestCategory("Division")]
        [DataRow(16, 2)]
        [DataRow(464, 7)]
        [DataRow(27, -51)]
        [DataRow(8789100, 913)]
        public void DividingTwoNumberShouldNotFollowAssociativeProperty(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 5;
            //double right = 10;

            double result1 = Calculator.CalculatorClass.divide(left, right);
            double result2 = Calculator.CalculatorClass.divide(right, left);
            Assert.IsTrue(result1 != result2);

        }

        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(16, 2)]
        [DataRow(464, 7)]
        [DataRow(27, -51)]
        [DataRow(8789100, 913)]
        public void SubtractingTwoNumberShouldNotFollowAssociativeProperty(double left, double right)
        {
            //Calculator.CalculatorClass calc = new Calculator.CalculatorClass();
            //double left = 5;
            //double right = 10;

            double result1 = Calculator.CalculatorClass.subtract(left, right);
            double result2 = Calculator.CalculatorClass.subtract(right, left);
            Assert.IsTrue(result1 != result2);

        }
    }
}
