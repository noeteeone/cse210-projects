using System;

namespace Exercise3;

class Program
{
    static void Main()
    {
        //int number1 = 15;
        Random randomGenerator = new Random();
        int number1 = randomGenerator.Next(1, 50);
        Console.WriteLine("Enter your number?");
        string input = Console.ReadLine();
        int number2 = int.Parse(input);
        //while (number2 != number1)
        //{
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
        //}
    }
}