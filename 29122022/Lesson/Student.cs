using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
        public Student()
        {
            Counter++;
            No = Counter;
        }
        public static int Counter;
        public readonly int No;
        public string FullName;
        public string GroupNo;
    }
}
