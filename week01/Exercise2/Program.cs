using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace Exercise2;

static class Program
{
    static void Main()
    {
        Console.WriteLine("What is your percentage score?");
        string mark = Console.ReadLine();
        int score = int.Parse(mark);
        int LastDigit = score  % 10;
        string grade = "";
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        if (score >= 70)
        {
            Console.WriteLine("Congratulations You Passed The Course!");
        }
        else if (score < 70)
        {
            Console.WriteLine("Unfortunately You Did not Pass, Try Again");
        }
        if (LastDigit >= 7 && score > 97 && score < 60)
        {
            Console.WriteLine($"Your grade is: {grade}+");
        }
        else if (LastDigit <= 3 && score < 60)
        {
            Console.WriteLine($"Your grade is: {grade}-");
        }
        else
        {
            Console.WriteLine($"Your grade is: {grade}");
        }
    }
}
