using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class CalculatorTest
    {
        //Test Methods for Addition
        //--------------------------

        //Add - Test 1
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1,2)]
        [DataRow(4,7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddTwoPositiveNumbersShouldGivePositiveNumber(double left, double right)
        { 
            double result = Calculator.CalculatorClass.add(left,right);
            //Assert.AreEqual(3d, result);
            Assert.IsTrue(result > 0);
        }

        //Add - Test 2
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(-1, -2)]
        [DataRow(-4, -7)]
        [DataRow(-2, -51)]
        [DataRow(-102, -913)]
        public void AddTwoNegativeNumbersShouldGiveNegativeNumbers(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue(result < 0);
        }

        //Add - Test 3
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddTwoDoublesShouldGiveDoubles(double left, double right)
        {
            object result = Calculator.CalculatorClass.add(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        //Add - Test 4
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void AddingTwoNumberShouldFollowAssociativeProperty(double left, double right)
        {
            double result1 = Calculator.CalculatorClass.add(left, right);
            double result2 = Calculator.CalculatorClass.add(right, left);
            Assert.IsTrue(result1 == result2);
        }

        //Add - Test 5
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(0, -2)]
        [DataRow(0, 7)]
        [DataRow(-257, 0)]
        [DataRow(87, 0)]
        public void AddingWithZeroShouldResultInSameNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            if (left == 0)
            {
                Assert.IsTrue(result == right);
            }
            else if (right == 0)
            {
                Assert.IsTrue(result == left);
            }
            
        }

        //Add - Test 6
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(2, 2)]
        [DataRow(4, 8)]
        [DataRow(2, 52)]
        [DataRow(88, 916)]
        public void AddTwoPositiveEvenNumbersShouldGivePositiveEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue((result > 0)&&(result % 2 == 0));
        }


        //Add - Test 7
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(3, 3)]
        [DataRow(5, 9)]
        [DataRow(3, 53)]
        [DataRow(89, 917)]
        public void AddTwoPositiveOddNumbersShouldGivePositiveEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue((result > 0) && (result % 2 == 0));
        }


        //Add - Test 8
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(3, 4)]
        [DataRow(5, 10)]
        [DataRow(3, 54)]
        [DataRow(90, 917)]
        public void AddPositiveOddAndEvenNumbersShouldGivePositiveOddNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue((result > 0) && (result % 2 == 1));
        }


        //Add - Test 9
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(-2, -2)]
        [DataRow(-4, -8)]
        [DataRow(-2, -52)]
        [DataRow(-88, -916)]
        public void AddTwoNegativeEvenNumbersShouldGiveNegativeEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue((result < 0) && (result % 2 == 0));
        }

        //Add - Test 10
        [TestMethod]
        [TestCategory("Addition")]
        [DataRow(-3, -3)]
        [DataRow(-5, -9)]
        [DataRow(-3, -53)]
        [DataRow(-89, -917)]
        public void AddTwoNegativeOddNumbersShouldGiveNegativeEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.add(left, right);
            Assert.IsTrue((result < 0) && (result % 2 == 0));
        }

        //Test Methods for Subtraction
        //------------------------------

        //Sub - Test 1
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(16, 2)]
        [DataRow(464, 7)]
        [DataRow(27, -51)]
        [DataRow(8789100, 913)]
        public void SubtractingTwoNumberShouldNotFollowAssociativeProperty(double left, double right)
        {
            double result1 = Calculator.CalculatorClass.subtract(left, right);
            double result2 = Calculator.CalculatorClass.subtract(right, left);
            Assert.IsTrue(result1 != result2);

        }

        //Sub - Test 2
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(7, 2)]
        [DataRow(47, 7)]
        [DataRow(52, 51)]
        [DataRow(987, 913)]
        public void SubtractTwoDescendingPositiveNumbersShouldGivePositiveNumberOrZero(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            //Assert.AreEqual(3d, result);
            Assert.IsTrue(result >= 0);
        }

        //Sub - Test 3
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(-2, -7)]
        [DataRow(-7 ,- 47)]
        [DataRow(-51 ,- 52)]
        [DataRow(-913 , -987)]
        public void SubtractTwoDescendingNegativeNumbersShouldGivePositiveNumberOrZero(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result >= 0);
        }

        //Sub - Test 4
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(-7, -2)]
        [DataRow(-47, -7)]
        [DataRow(-52, -51)]
        [DataRow(-987, -913)]
        public void SubtractTwoAscendingNegativeNumbersShouldGiveNegativeveNumberOrZero(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result <= 0);
        }

        //Sub - Test 5
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(-7, -2)]
        [DataRow(-47, -7)]
        [DataRow(-52, -51)]
        [DataRow(-987, -913)]
        public void SubtractTwoAscendingPositiveNumbersShouldGiveNegativeNumberOrZero(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result <= 0);
        }

        //Sub - Test 6
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(0, 2)]
        [DataRow(0, 7)]
        [DataRow(0, 90)]
        [DataRow(0, 87)]
        public void SubtractingFromZeroShouldResultInNegatingtheNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result <= 0);
        }

        //Sub - Test 7
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void SubtractTwoDoublesShouldGiveDoubles(double left, double right)
        {
            object result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        //Sub - Test 8
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(2, 2)]
        [DataRow(4, 8)]
        [DataRow(2, 52)]
        [DataRow(90, 914)]
        public void SubtractTwoEvenNumbersShouldGiveEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result % 2 == 0);
        }

        //Sub - Test 9
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(1, 3)]
        [DataRow(5, 7)]
        [DataRow(3, 51)]
        [DataRow(89, 913)]
        public void SubtractTwoOddNumbersShouldGiveEvenNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsTrue(result % 2 == 0);
        }

        //Sub - Test 10
        [TestMethod]
        [TestCategory("Subtraction")]
        [DataRow(2, 3)]
        [DataRow(6, 7)]
        [DataRow(4, 51)]
        [DataRow(8972, 913)]
        public void SubtractOddNumberFromEvenNumberShouldGiveOddNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.subtract(left, right);
            Assert.IsFalse(result % 2 == 0);
            //Assert.IsTrue((result % 2) != 0);
        }

        //Test Methods for Multiplication
        //------------------------------------

        //Mul - Test 1
        [TestMethod]
        [TestCategory("Multiplication")]
        [DataRow(1, 2)]
        [DataRow(4, 7)]
        [DataRow(2, 51)]
        [DataRow(87, 913)]
        public void MultiplyingTwoNumberShouldFollowAssociativeProperty(double left, double right)
        {
            double result1 = Calculator.CalculatorClass.multiply(left, right);
            double result2 = Calculator.CalculatorClass.multiply(right, left);
            Assert.IsTrue(result1 == result2);

        }

        //Test Methods for Division
        //--------------------------

        //Div - Test 1
        [TestMethod]
        [TestCategory("Division")]
        [TestCategory("Exception")]
        [DataRow(1, 0)]
        [DataRow(-4, 0)]
        [DataRow(2, 0)]
        [DataRow(87, 0)]
        public void DivideByZeroShouldResultInAnException(double left, double right)
        {
            Assert.ThrowsException<DivideByZeroException>(()=>Calculator.CalculatorClass.divide(left, right));
        }

        //Div - Test 2
        [TestMethod]
        [TestCategory("Division")]
        [DataRow(16, -2)]
        [DataRow(464, -7)]
        [DataRow(27, -51)]
        [DataRow(8789100, -913)]
        public void DividePositiveByNegativeNumberShouldGiveNegativeNumber(double left, double right)
        {
            double result = Calculator.CalculatorClass.divide(left, right);
            Assert.IsTrue(result < 0);

        }

        //Div - Test 3
        [TestMethod]
        [TestCategory("Division")]
        [DataRow(16, 2)]
        [DataRow(464, 7)]
        [DataRow(27, -51)]
        [DataRow(8789100, 913)]
        public void DividingTwoNumberShouldNotFollowAssociativeProperty(double left, double right)
        {
            double result1 = Calculator.CalculatorClass.divide(left, right);
            double result2 = Calculator.CalculatorClass.divide(right, left);
            Assert.IsTrue(result1 != result2);

        }

       
    }
}
