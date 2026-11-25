using System;

namespace Homework;

public class Assignment
{
    public string StudentName { get; set; }
    public string Topic { get; set; }
}

    // Child Class 1: Inherits from Assignment
    public class MathAssignment : Assignment
    {
        public string TextBookSection { get; set; }
        public string Problems { get; set; }
        
        // Constructor calls the parent constructor using 'base'
        public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        {
            StudentName = studentName;
            Topic = topic;
            TextBookSection = textBookSection;
            Problems = problems;
        }
    }


   