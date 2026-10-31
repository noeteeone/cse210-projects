using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter a list of numbers, type 0 when finished");
        //string input = Console.ReadLine();
        //int number = int.Parse(input);
        List<int> numbers = new List<int>();
        int count  = 0;
        //int UserNumber = 0;
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (true)
        {
            //Console.WriteLine("Enter a list of numbers, type 0 when finished");
            Console.WriteLine("Enter number : ");
            string input = Console.ReadLine();
            int userNumber = int.Parse(input);
            if (userNumber == 0)
            {
                break;
            }
            else if (userNumber != 0)
            {
                count = count + 1;
                //numbers = new List<int>();
                numbers.Add(userNumber);
                sum = sum + userNumber;
                Console.WriteLine();
                Console.WriteLine($"The current sum is {sum}");
                Console.WriteLine();
                //Console.WriteLine("Enter number : ");
                //input = Console.ReadLine();
                //userNumber = int.Parse(input);
            }
        Console.WriteLine($"You entered {count} numbers.");
        Console.WriteLine($"The Total sum is {sum}.");
        }
    }
}

