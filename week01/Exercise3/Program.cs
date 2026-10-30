using System;

namespace Exercise3;

class Program
{
    static void Main()
    {
        int number1 = 15;
        Console.WriteLine("Enter your number?");
        string input = Console.ReadLine();
        int number2 = int.Parse(input);
        if (number2 < number1)
        {
            Console.WriteLine("Lower");
        }
        else if (number2 > number1)
        {
            Console.WriteLine("higher");
        }
        else if (number2 == number1)
        {
            Console.WriteLine("Congratulations you guessed right");
        }
    }
}