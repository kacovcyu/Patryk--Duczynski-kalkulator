using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Podaj 1 liczbę:");
                    var number1 = GetInput();

                    Console.WriteLine("Co chcesz zrobić: '+', '-', '*', '/'.");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj 2 liczbę:");
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Wynik to: {result}.\n");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość nie jest liczbą.\n");

            return input;
        }

        private static int Calculate(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;

                default:
                    throw new Exception("Wybrałeś złą operację!\n");
            }
        }
    }
}