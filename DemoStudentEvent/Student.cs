using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStudentEvent
{
    public delegate void ChangedEventHandler(Object sender, EventArgs e);
    class Student
    {
        private int idNum;
        private double gpa;
        public event ChangedEventHandler Changed;
        public int IdNum
        {
            get
            {
                return idNum;
            }
            set
            {
                idNum = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
                OnChanged(EventArgs.Empty);
            }
        }

        private void OnChanged(EventArgs e)
        {
            Changed(this, e);
        }

    }
}
