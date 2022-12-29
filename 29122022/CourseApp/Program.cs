using System;

namespace CourseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group("Programming");
            Group group2 = new Group("System");
            Group group3 = new Group("Programming");

            Console.WriteLine(group1.No);
            Console.WriteLine(group2.No);
            Console.WriteLine(group3.No);


            Course codeAcademy = new Course { ProgrammingLimit = 20, DesignLimit = 4, SystemLimit = 10 };




        }
    }
}
