using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== C# Multi-Tool Program =====");
            Console.WriteLine("1. Print # Pattern");
            Console.WriteLine("2. Area Calculator");
            Console.WriteLine("3. Temperature Converter");
            Console.WriteLine("4. Even or Odd Checker");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintPattern();
                    break;
                case "2":
                    AreaCalculator();
                    break;
                case "3":
                    TemperatureConverter();
                    break;
                case "4":
                    EvenOddChecker();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    static void PrintPattern()
    {
        Console.WriteLine("Enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    static void AreaCalculator()
    {
        Console.WriteLine("Choose shape (circle/triangle):");
        string shape = Console.ReadLine().ToLower();

        double area = 0;

        if (shape == "circle")
        {
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
        }
        else if (shape == "triangle")
        {
            Console.WriteLine("Enter base:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height:");
            double h = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * b * h;
        }
        else
        {
            Console.WriteLine("Invalid shape.");
            return;
        }

        Console.WriteLine($"Area = {area}");
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("Convert to: Celsius or Fahrenheit?");
        string choice = Console.ReadLine().ToLower();

        if (choice == "celsius")
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {c}");
        }
        else if (choice == "fahrenheit")
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {f}");
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    static void EvenOddChecker()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }
    }
}
