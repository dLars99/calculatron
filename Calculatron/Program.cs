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
                Console.WriteLine("7) Advanced: Write your own equation");
                Console.WriteLine("0) Exit");
                Console.Write("\n> ");

                choice = Console.ReadLine();

                double firstNum = 0;
                double secondNum = 0;
                if (choice != "0" && choice != "5" && choice != "6" && choice != "7")
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
                switch (choice)
                {
                    case "1":
                        calculator.Addition(firstNum, secondNum);
                        break;
                    case "2":
                        calculator.Subtraction(firstNum, secondNum);
                        break;
                    case "3":
                        calculator.Multiplication(firstNum, secondNum);
                        break;
                    case "4":
                        calculator.Division(firstNum, secondNum);
                        break;
                    case "5":
                        calculator.Square(firstNum);
                        break;
                    case "6":
                        calculator.SquareRoot(firstNum);
                        break;
                    case "7":
                        calculator.Advanced();
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
