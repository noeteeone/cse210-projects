using System;

// Program Entry Point to test the code
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssignment math = new MathAssignment("Roberto Rodriguez", " - Fractions", "Section 7.3", "8 to 19");
        Console.WriteLine($"{math.StudentName}  {math.Topic};");
        Console.WriteLine($"{math.TextBookSection} Problems {math.Problems}.");
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
