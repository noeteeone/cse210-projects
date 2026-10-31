using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int count  = 0;
        float sum = 0;
        int largestNumber = 0;
        int smallestNumber = 999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (true)
        {
            Console.Write("Enter number : ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            numbers.Add(userNumber);
            if (userNumber > largestNumber)
            {
                largestNumber = userNumber;
            }
            if (userNumber > 0 && userNumber < smallestNumber)
            {
                smallestNumber = userNumber;
            }
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
                if (userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                }
                if (userNumber > 0 && userNumber < smallestNumber)
                {
                    smallestNumber = userNumber;
                }
            }
    Console.WriteLine($"You entered {count} numbers.");
    Console.WriteLine($"The Total sum is {sum}.");
    float averageNumber = sum / count;
    Console.WriteLine($"The average number is {averageNumber}");
    Console.WriteLine();
    Console.WriteLine($"The largest number is {largestNumber}");
    Console.WriteLine($"The smallest positive number is {smallestNumber}");
    foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    break;
        }
    }
}

