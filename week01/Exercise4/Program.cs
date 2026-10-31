using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int count  = 0;
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (true)
        {
            Console.Write("Enter number : ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            sum = sum + userNumber;
            if (userNumber == 0)
            {
                break;
            }
            while (userNumber != 0)
            {
                count = count + 1;
                Console.Write("Enter number : ");
                input = Console.ReadLine();
                userNumber = int.Parse(input);
                numbers.Add(userNumber);
                sum = sum + userNumber;
            }
    Console.WriteLine($"You entered {count} numbers.");
    Console.WriteLine($"The Total sum is {sum}.");
    int averageNumber = sum / count;
    Console.WriteLine($"The average of the number is {averageNumber}");
    Console.WriteLine();
    break;
        }
    }
}

