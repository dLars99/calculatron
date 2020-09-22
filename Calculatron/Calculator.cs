using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatron
{
    public class Calculator
    {
        private double _answer;
        public void Addition(double num1, double num2)
        {
            _answer = num1 + num2;
            Console.WriteLine($"The result of adding {num1} and {num2} is {_answer}.");
        }
        public void Subtraction(double num1, double num2)
        {
            _answer = num1 - num2;
            Console.WriteLine($"The result of subtracting {num2} from {num1} is {_answer}.");
        }
        public void Multiplication(double num1, double num2)
        {
            _answer = num1 * num2;
            Console.WriteLine($"The result of multiplying {num1} and {num2} is {_answer}.");
        }
        public void Division(double num1, double num2)
        {
            try
            {
                _answer = num1 / num2;
                Console.WriteLine($"The result of dividing {num1} by {num2} is {_answer}.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        public void Square(double num)
        {
            _answer = num * num;
            Console.WriteLine($"{num} squared is {_answer}.");
        }
        public void SquareRoot(double num)
        {
            try
            {
                _answer = Math.Sqrt(num);
                Console.WriteLine($"The square root of {num} is {_answer}.");
            }
            catch
            {
                Console.WriteLine($"Square root of {num} is undefined.");
            }
        }
        public void Advanced()
        {
            Console.WriteLine("Please enter a simple equation with, at most, two numbers.");
            Console.WriteLine("Please separate all characters with a space.");
            Console.WriteLine("(Example: 2 + 4, 15 / 12, 6 ^, etc.)");
            Console.WriteLine("Acceptable operators: +, -, *, /, ^ (Square), v (Square root)");
            string equation = Console.ReadLine();

            string[] strNums = equation.Split(" ");
            try
            {
                // Parse the first and third character -- the two numbers
                double num1 = Double.Parse(strNums[0]);
                double num2 = 0;
                if (strNums.Length > 2)
                    num2 = Double.Parse(strNums[2]);

                // Select an operation based on the second character, the operator
                switch (strNums[1])
                {
                    case "+":
                        Addition(num1, num2);
                        break;
                    case "-":
                        Subtraction(num1, num2);
                        break;
                    case "*":
                        Multiplication(num1, num2);
                        break;
                    case "/":
                        Division(num1, num2);
                        break;
                    case "^":
                        Square(num1);
                        break;
                    case "v":
                        SquareRoot(num1);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
