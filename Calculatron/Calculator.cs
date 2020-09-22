using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatron
{
    public class Calculator
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double? Division(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
        }
        public double Square(double num)
        {
            return num * num;
        }
        public double? SquareRoot(double num)
        {
            try
            {
                return Math.Sqrt(num);
            }
            catch
            {
                Console.WriteLine($"Square root of {num} is undefined.");
                return null;
            }
        }
    }
}
