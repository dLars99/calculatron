using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

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
            Console.WriteLine("Welcome to Calculatron 3000!");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");
            Console.Write("\n> ");
            
            string choice = Console.ReadLine();
            if (choice != "0")
            {
                Console.Write("Please enter the first number: ");
                string first = Console.ReadLine();
                int firstNum = ConvertToInt(first);
                Console.Write("Please enter the second number: ");
                string second = Console.ReadLine();
                int secondNum = ConvertToInt(second);
            }
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }
        }

        static int ConvertToInt(string str)
        {
            try
            {
                int num = Int32.Parse(str);
                return num;
            }
            catch (Exception)
            {
                Console.Write("Please input a number. ");
                str = Console.ReadLine();
                return ConvertToInt(str);
            }
        }
    }
}
