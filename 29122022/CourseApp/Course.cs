using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    internal class Course
    {
        private Group[] _groups = new Group[0];
        public Group[] Groups => _groups;

        public int ProgrammingLimit;
        public int SystemLimit;
        public int DesignLimit;

        public void AddGroup(string type,int  studentCount)
        {
            if (CountByType(type) < GetLimitByType(type))
            {
                Group group = new Group(type) { StudentCount = studentCount };

                Array.Resize(ref _groups, _groups.Length + 1);
                _groups[_groups.Length - 1] = group;
            }
        }

        private int CountByType(string type)
        {
            int count = 0;

            for(int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i].Type == type)
                    count++;
            }

            return count;
        }

        public int GetLimitByType(string type)
        {
            switch (type)
            {
                case "Programming":
                    return this.ProgrammingLimit;
                case "Design":
                    return this.DesignLimit;
                case "System":
                    return this.SystemLimit;
                default:
                    return 0;
            }
        }
    }
}
