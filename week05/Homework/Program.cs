using System;
using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        //Maths Assignment
        MathAssignment math = new MathAssignment("Roberto Rodriguez", " - Fractions", "Section 7.3", "8 to 19");
        Console.WriteLine();
        Console.WriteLine($"{math.StudentName}  {math.Topic}");
        Console.WriteLine($"{math.TextBookSection} Problems {math.Problems}.");
        Console.WriteLine();

        //Writing Assignment
        WritingAssignment writing = new WritingAssignment("Mary Waters", " - European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"{writing.StudentName} {writing.Topic}");
        Console.WriteLine($"{writing.Title}");
        Console.WriteLine();
    }
}

class MathAssignment
{
    public string StudentName { get; }
    public string Topic { get; }
    public string TextBookSection { get; }
    public string Problems { get; }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
    {
        StudentName = studentName;
        Topic = topic;
        TextBookSection = textBookSection;
        Problems = problems;
    }
}
