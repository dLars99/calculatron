using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Calculatron
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Calculatron 3000!");
                Console.WriteLine("1) Add two numbers");
                Console.WriteLine("2) Subtract two numbers");
                Console.WriteLine("3) Multiply two numbers");
                Console.WriteLine("4) Divide two numbers");
                Console.WriteLine("5) Square a number");
                Console.WriteLine("6) Find the square root of a number");
                Console.WriteLine("0) Exit");
                Console.Write("\n> ");

                choice = Console.ReadLine();

                double firstNum = 0;
                double secondNum = 0;
                if (choice != "0" && choice != "5" && choice != "6")
                {
                    Console.Write("Please enter two numbers with a space in between: ");
                    string numbers = Console.ReadLine();
                    string[] strNums = numbers.Split(" ");
                    try
                    {
                        firstNum = Double.Parse(strNums[0]);
                        secondNum = Double.Parse(strNums[1]);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Improper input. Restarting.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        MainMenu();
                    }

                }
                else if (choice == "5" || choice == "6")
                {
                    Console.Write("Please enter a number: ");
                    string numbers = Console.ReadLine();
                    try
                    {
                        firstNum = Int32.Parse(numbers);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Improper input. Restarting.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        MainMenu();
                    }
                }
                Calculator calculator = new Calculator();
                double? answer;
                switch (choice)
                {
                    case "1":
                        answer = calculator.Addition(firstNum, secondNum);
                        Console.WriteLine($"The result of adding {firstNum} and {secondNum} is {answer}.");
                        break;
                    case "2":
                        answer = calculator.Subtraction(firstNum, secondNum);
                        Console.WriteLine($"The result of subtracting {secondNum} from {firstNum} is {answer}.");
                        break;
                    case "3":
                        answer = calculator.Multiplication(firstNum, secondNum);
                        Console.WriteLine($"The result of multiplying {firstNum} and {secondNum} is {answer}.");
                        break;
                    case "4":
                        answer = calculator.Division(firstNum, secondNum);
                        if (answer != null)
                        {
                            Console.WriteLine($"The result of dividing {firstNum} by {secondNum} is {answer}.");
                        }
                        break;
                    case "5":
                        answer = calculator.Square(firstNum);
                        Console.WriteLine($"{firstNum} squared is {answer}.");
                        break;
                    case "6":
                        double? decAnswer = calculator.SquareRoot(firstNum);
                        if (decAnswer != null)
                        {
                            Console.WriteLine($"The square root of {firstNum} is {decAnswer}.");
                        }
                        break;
                    case "0":
                        break;
                    default:
                        MainMenu();
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            } while (choice != "0");
        }
    }
}
