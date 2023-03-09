
using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string status ;
            do
            {
                int res;
                int firstNumber;
                int secondNumber;

                try
                {
                    Console.Write("Enter first number:");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number:");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Wrong input Numbers Only");
                    return;

                }
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":
                        res = firstNumber + secondNumber;
                        Console.WriteLine($"The sum of the {firstNumber} and {secondNumber} is:" + res);
                        break;
                    case "-":
                        res = firstNumber - secondNumber;
                        Console.WriteLine($"The subtraction  of the {firstNumber} and {secondNumber} is:" + res);
                        break;
                    case "*":
                        res = firstNumber * secondNumber;
                        Console.WriteLine($"The multiplication  of the {firstNumber} and {secondNumber} is:" + res);
                        break;
                    case "/":
                      
                        try
                        {
                            res = firstNumber / secondNumber;
                            Console.WriteLine($"The division  of the {firstNumber} and {secondNumber} is:" + res);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.Write("Cannot divide by zero. Please try again.");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                status = Console.ReadLine();
            }
            while (status == "y" || status == "Y");
        }
    }

}
