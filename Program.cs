// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main(string[] args)
    {
        // First Task: Declaring and initializing variables
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Is Admin: " + isAdmin);

        // Second Task: This section checks if a number is odd or even
        Console.WriteLine("\nEnter a number:");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Third Task: This method Print numbers from 1 to 10 using a for loop
        Console.WriteLine("\n Print Numbers 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Fourth Task: Using a foreach loop to calculate the Sum of numbers in an array
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;

        Console.WriteLine("\nInitializing array of numbers and their sum:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
        }
        Console.WriteLine("Sum of array elements: " + sum);

        // Final Task: Call the Greet method and output a personalized greeting message
        Console.WriteLine("\nFinal Task:");
        Greet("Alice");
    }

    // Final Task: Greet method
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

