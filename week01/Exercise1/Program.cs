using System;

namespace Exercise1
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
        }
    }
}