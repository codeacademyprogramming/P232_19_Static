using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    internal class Group
    {
        static Group()
        {
            _noCount = 100;
        }

        public Group(string type)
        {
            _noCount++;
            this.Type = type;
            No = type[0]+_noCount.ToString();
        }

        static int _noCount;
        public string No;
        public int StudentCount;
        public string Type;
    }
}
