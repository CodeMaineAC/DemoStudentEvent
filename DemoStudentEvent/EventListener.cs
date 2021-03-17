using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStudentEvent
{
    class EventListener
    {
        private Student stu;
        public EventListener(Student student)
        {
            stu = student;
            stu.Changed += new ChangedEventHandler(StudentChanged);
        }

        private void StudentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("The student has changed.");
            Console.WriteLine("   ID# {0}   GPA {1}", stu.IdNum, stu.Gpa);
        }
    }
}
