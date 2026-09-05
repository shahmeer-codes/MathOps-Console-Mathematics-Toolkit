using System;

namespace MathOps;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("\t<--- MathOps: Mathematics Toolkit --->\n");

            Console.WriteLine("1). Basic Arithmetic");
            Console.WriteLine("2). Square Root");
            Console.WriteLine("3). Minimum / Maximum");
            Console.WriteLine("4). Power");
            Console.WriteLine("5). Absolute Value");
            Console.WriteLine("6). Remainder");
            Console.WriteLine("7). Rounding");
            Console.WriteLine("8). Ceiling");
            Console.WriteLine("9). Floor");
            Console.WriteLine("10). Trigonometry");
            Console.WriteLine("11). Logarithm");
            Console.WriteLine("12). Exit");

            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("\nInvalid input.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("<--- Basic Arithmetic --->\n");

                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n1). Addition");
                    Console.WriteLine("2). Subtraction");
                    Console.WriteLine("3). Multiplication");
                    Console.WriteLine("4). Division");

                    Console.Write("\nEnter operation: ");
                    int operation = Convert.ToInt32(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine($"\nResult: {num1 + num2}");
                            break;

                        case 2:
                            Console.WriteLine($"\nResult: {num1 - num2}");
                            break;

                        case 3:
                            Console.WriteLine($"\nResult: {num1 * num2}");
                            break;

                        case 4:
                            if (num2 == 0)
                                Console.WriteLine("\nCannot divide by zero.");
                            else
                                Console.WriteLine($"\nResult: {num1 / num2}");
                            break;

                        default:
                            Console.WriteLine("\nInvalid operation.");
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("<--- Square Root --->\n");

                    Console.Write("Enter a number: ");
                    double sqrtNumber = Convert.ToDouble(Console.ReadLine());

                    if (sqrtNumber < 0)
                        Console.WriteLine("\nSquare root of a negative number is not a real number.");
                    else
                        Console.WriteLine($"\nResult: {Math.Sqrt(sqrtNumber)}");

                    break;

                case 3:
                    Console.WriteLine("<--- Minimum / Maximum --->\n");

                    Console.Write("Enter first number: ");
                    double first = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double second = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n1). Find Minimum");
                    Console.WriteLine("2). Find Maximum");

                    Console.Write("\nEnter your choice: ");
                    int minMaxChoice = Convert.ToInt32(Console.ReadLine());

                    switch (minMaxChoice)
                    {
                        case 1:
                            Console.WriteLine($"\nMinimum: {Math.Min(first, second)}");
                            break;

                        case 2:
                            Console.WriteLine($"\nMaximum: {Math.Max(first, second)}");
                            break;

                        default:
                            Console.WriteLine("\nInvalid choice.");
                            break;
                    }

                    break;

                case 4:
                    Console.WriteLine("<--- Power --->\n");

                    Console.Write("Enter base: ");
                    double baseNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter exponent: ");
                    double exponent = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nResult: {Math.Pow(baseNumber, exponent)}");

                    break;

                case 5:
                    Console.WriteLine("<--- Absolute Value --->\n");

                    Console.Write("Enter a number: ");
                    double absoluteNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nResult: {Math.Abs(absoluteNumber)}");

                    break;

                case 6:
                    Console.WriteLine("<--- Remainder --->\n");

                    Console.Write("Enter first number: ");
                    double dividend = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double divisor = Convert.ToDouble(Console.ReadLine());

                    if (divisor == 0)
                        Console.WriteLine("\nCannot calculate remainder with zero.");
                    else
                        Console.WriteLine($"\nRemainder: {dividend % divisor}");

                    break;

                case 7:
                    Console.WriteLine("<--- Rounding --->\n");

                    Console.Write("Enter a number: ");
                    double roundNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter decimal places: ");
                    int decimals = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nResult: {Math.Round(roundNumber, decimals)}");

                    break;

                case 8:
                    Console.WriteLine("<--- Ceiling --->\n");

                    Console.Write("Enter a number: ");
                    double ceilingNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nResult: {Math.Ceiling(ceilingNumber)}");

                    break;

                case 9:
                    Console.WriteLine("<--- Floor --->\n");

                    Console.Write("Enter a number: ");
                    double floorNumber = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nResult: {Math.Floor(floorNumber)}");

                    break;

                case 10:
                    Console.WriteLine("<--- Trigonometry --->\n");

                    Console.WriteLine("1). Sine");
                    Console.WriteLine("2). Cosine");
                    Console.WriteLine("3). Tangent");

                    Console.Write("\nEnter your choice: ");
                    int trigChoice = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nEnter angle in degrees: ");
                    double degrees = Convert.ToDouble(Console.ReadLine());

                    double radians = degrees * Math.PI / 180;

                    switch (trigChoice)
                    {
                        case 1:
                            Console.WriteLine($"\nSine: {Math.Sin(radians)}");
                            break;

                        case 2:
                            Console.WriteLine($"\nCosine: {Math.Cos(radians)}");
                            break;

                        case 3:
                            Console.WriteLine($"\nTangent: {Math.Tan(radians)}");
                            break;

                        default:
                            Console.WriteLine("\nInvalid choice.");
                            break;
                    }

                    break;

                case 11:
                    Console.WriteLine("<--- Logarithm --->\n");

                    Console.Write("Enter a positive number: ");
                    double logNumber = Convert.ToDouble(Console.ReadLine());

                    if (logNumber <= 0)
                    {
                        Console.WriteLine("\nLogarithm requires a positive number.");
                    }
                    else
                    {
                        Console.WriteLine("\n1). Natural Logarithm");
                        Console.WriteLine("2). Base-10 Logarithm");

                        Console.Write("\nEnter your choice: ");
                        int logChoice = Convert.ToInt32(Console.ReadLine());

                        switch (logChoice)
                        {
                            case 1:
                                Console.WriteLine($"\nResult: {Math.Log(logNumber)}");
                                break;

                            case 2:
                                Console.WriteLine($"\nResult: {Math.Log10(logNumber)}");
                                break;

                            default:
                                Console.WriteLine("\nInvalid choice.");
                                break;
                        }
                    }

                    break;

                case 12:
                    Console.WriteLine("Thank you for using MathOps.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice != 12)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }

        } while (choice != 12);
    }
}
