using System;

namespace Inheritance
{
    // Parent Class
    public class Assignment
    {
        // Changed to protected init/set so child classes can access them
        public string StudentName { get; protected set; }
        public string Topic { get; protected set; }

        // Parent Constructor
        public Assignment(string studentName, string topic)
        {
            StudentName = studentName;
            Topic = topic;
        }
    }
}

    
