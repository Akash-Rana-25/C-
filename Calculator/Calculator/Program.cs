
using System;

namespace calculator
{
    class Program

    {
         static int firstNumber;
         static int secondNumber;
        public static void FirstRead()
        {
            Console.Write("Enter first number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

        }
        public static void SecoundRead()
        {
            Console.Write("Enter second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {


            string status;
            do
            {
                int res;

                try
                {
                    FirstRead();
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Wrong input Numbers Only");
                    FirstRead();

                }
                try
                {
                    SecoundRead();
                }
                catch (System.FormatException)

                {
                    Console.WriteLine("Wrong input Numbers Only");
                    SecoundRead();

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
