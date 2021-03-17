using System;

namespace DemoStudentEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oneStu = new Student();
            EventListener listener = new EventListener(oneStu);
            oneStu.IdNum = 2345;
            oneStu.Gpa = 3.2;

            oneStu.Gpa = 2.5;
        }
    }
}
