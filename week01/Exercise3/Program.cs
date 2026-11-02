using System;

namespace Exercise3;

class Program
{
    static void Main()
    {
        Console.Write("Do you want to play the gussing game? : ");
        string answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            Console.WriteLine("Guess a number between 1 and 100");
        }
        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int number1 = randomGenerator.Next(1, 101);
            int number2 = 0;
            int count = 0;
            Console.WriteLine();
            while (number2 != number1)
            {
                Console.Write("Enter your number : ");
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
                    Console.WriteLine();
                    Console.WriteLine("Congratulations you guessed right");
                    Console.WriteLine($"You made {count} guesses");
                    Console.WriteLine();
                    Console.Write("Would you like to play again? : ");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("Guess a number between 1 and 100");
                    }
                }
            }
        }
    }
}