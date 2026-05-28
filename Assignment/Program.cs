using System;

class Program
{
    static void Main()
    {
        // Keep asking until a valid name is entered
        string name = "";
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        // Keep asking until a valid age is entered
        string age = "";
        while (string.IsNullOrWhiteSpace(age))
        {
            Console.Write("Enter your age: ");
            age = Console.ReadLine();
        }

        Console.WriteLine($"Hello, {name}. You are {age} years old.");

        // A calculator that will perform basic arithmetic operations
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine($"Result: {result}");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

        

    }
}