using System;

namespace Calculator
{
    public static class CalculatorClass
    {
        //Adds the two given numbers
        static public double add(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }

        //Subtracts the right number from the left number
        static public double subtract(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        //Multiplies the two given numbers
        static public double multiply(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }

        //Divides the left number by the right number
        static public double divide(double leftNumber, double rightNumber)
        {
            if (rightNumber != 0)
            {
                return leftNumber / rightNumber;
            }
            //throwing an exception when attempted to divide by zero
            throw new DivideByZeroException(@"Cannot  divide by zero");



        }
    }
}
