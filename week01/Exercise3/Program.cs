using System;

namespace Exercise3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Do you want to play the gussing game?");
        string answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer != "yes" && answer != "y")
        {
            return;
        }
        else if (answer == "yes" && answer == "y")
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
                    Console.WriteLine("Would you like to play again?");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();
                }
            }
        }
        //Console.WriteLine("Would you like to play again?");
        //answer = Console.ReadLine();
        //answer = answer.ToLower();
    }
}