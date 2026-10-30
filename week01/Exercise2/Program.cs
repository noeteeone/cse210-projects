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

        // Output the final result to the user
        Console.WriteLine($"Your grade is: {grade}");
    }
}
