using System;

namespace Inheritance
{
    // Child Class 2: Inherits from Assignment
    public class WritingAssignment : Assignment
    {
        public string Title { get; set; }

        // Constructor calls the parent constructor using 'base'
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            Title = title;
        }
    }
}


    