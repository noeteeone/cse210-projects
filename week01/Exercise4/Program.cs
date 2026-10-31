using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter a list of numbers, type 0 when finished");
        //string input = Console.ReadLine();
        //int number = int.Parse(input);
        int count  = 0;
        //int UserNumber = 0;
        int sum = 0;
        while (true)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string input = Console.ReadLine();
            int UserNumber = int.Parse(input);
            if (UserNumber == 0)
            {
                break;
            }
            else if (UserNumber != 0)
            {
                numbers = new List<int>();
                numbers.Add(UserNumber);
                sum = sum + UserNumber;
                Console.WriteLine();
                Console.WriteLine($"The sum is {sum}");
                Console.WriteLine("Enter number : ");
                input = Console.ReadLine();
                UserNumber = int.Parse(input);
            }
            else
            {
                return;
            }
        }
    }
}

