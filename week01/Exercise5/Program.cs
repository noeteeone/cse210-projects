using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the display function to run the application logic
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name : ");
        string input = Console.ReadLine();
        return input;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number : ");
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }

    static void DisplayResult()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
        Console.WriteLine();
    }
}