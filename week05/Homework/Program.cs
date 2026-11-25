using System;

// Program Entry Point to test the code
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssignment math = new MathAssignment("Alex", "Algebra", "Math Vol 1", "1 to 10");
        Console.WriteLine($"{math.StudentName} is doing {math.Topic} homework out of {math.TextBox}.");
    }
}


class MathAssignment
{
    public string StudentName { get; }
    public string Topic { get; }
    public string TextBox { get; }
    public string Section { get; }

    public MathAssignment(string studentName, string topic, string textBox, string section)
    {
        StudentName = studentName;
        Topic = topic;
        TextBox = textBox;
        Section = section;
    }
}
