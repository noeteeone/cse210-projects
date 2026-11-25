using System;

namespace Homework;

public class Assignment
{
    public string StudentName { get; }
    public string Topic { get; }

    public Assignment(string studentName, string topic)
    {
        StudentName = studentName;
        Topic = topic;
    }
}

public class MathAssignment : Assignment
{
    public string TextBookSection { get; set; }
    public string Problems { get; set; }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        : base(studentName, topic)
    {
        TextBookSection = textBookSection;
        Problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {TextBookSection} Problems {Problems}";
    }
}


   