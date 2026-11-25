using System;

namespace Inheritance
{
    // Child Class 2: Inherits from Assignment
    public class WritingAssignment : Assignment
    {
        private string _title;
        private string _studentName;

        // Constructor calls the parent constructor using 'base'
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
            _studentName = studentName;
        }
        public string GetWritingInformation()
        {
            // Notice that we are calling the getter here because _studentName is private in the base class
            string studentName = _studentName;

            return $"{_title} by {studentName}";
        }
    }
}


    