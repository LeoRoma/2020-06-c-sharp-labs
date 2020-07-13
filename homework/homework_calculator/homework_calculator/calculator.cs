using System;

namespace homework_calculator
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Zero as divisor is invalid");
            }
            return x / y;
        }

        public static double Modulus(double x, double y)
        {
            return x % y;
        }
    }
}
