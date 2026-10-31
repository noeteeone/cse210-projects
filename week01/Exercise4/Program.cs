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
            count = count + 1;
            sum = sum + userNumber;
            if (userNumber == 0)
            {
                break;
            }
            while (userNumber != 0)
            {
                count = count + 1;
                //sum = sum + userNumber;
                Console.Write("Enter number : ");
                input = Console.ReadLine();
                userNumber = int.Parse(input);
                numbers.Add(userNumber);
                sum = sum + userNumber;
                //count = count + 1;
                Console.WriteLine();
                Console.WriteLine($"The current sum is {sum}");
                Console.WriteLine();
            }
Console.WriteLine($"You entered {count} numbers.");
Console.WriteLine($"The Total sum is {sum}.");
Console.WriteLine();
        }
    }
}

