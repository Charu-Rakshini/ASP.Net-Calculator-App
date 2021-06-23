using System;

namespace Calculator
{
    public class CalculatorClass
    {
        static public double add(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }

        static public double subtract(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        static public double multiply(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }

        static public double divide(double leftNumber, double rightNumber)
        {
            if (rightNumber != 0)
            {
                return leftNumber / rightNumber;
            }
            throw new DivideByZeroException(@"Cannot  divide by zero");



        }
    }
}
