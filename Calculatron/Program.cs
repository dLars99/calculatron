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
                Console.WriteLine("0) Exit");
                Console.Write("\n> ");

                choice = Console.ReadLine();

                int firstNum = 0;
                int secondNum = 0;
                if (choice != "0")
                {
                    Console.Write("Please enter two numbers with a space in between: ");
                    string numbers = Console.ReadLine();
                    string[] strNums = numbers.Split(" ");
                    try
                    {
                        firstNum = Int32.Parse(strNums[0]);
                        secondNum = Int32.Parse(strNums[1]);
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
                int? answer;
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
