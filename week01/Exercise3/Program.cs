using System;

namespace Exercise3;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int number1 = randomGenerator.Next(1, 50);
        int number2 = 0;
        int count = 0;
        while (number2 != number1)
        {
            Console.WriteLine("Enter your number?");
            string input = Console.ReadLine();
            number2 = int.Parse(input);
            count = count + 1;
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
                Console.WriteLine($"You made {count} guesses");
            }
        }
    }
}