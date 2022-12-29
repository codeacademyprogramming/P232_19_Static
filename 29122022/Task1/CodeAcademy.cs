using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class CodeAcademy:IUniversityPortal
    {
        public CodeAcademy()
        {
            //_students = new Student[0];
        }

        public Student[] Students => _students;
        private Student[] _students = new Student[0];

        public ProcessResult Login(string email,string password)
        {
            ProcessResult result = new ProcessResult();
            Student student = FindByEmail(email);

            if (student == null)
            {
                result.IsSucceed = false;
                result.AddError($"Student not foudn with email {email}");
                return result;
            }

            if (student.Password != password)
            {
                result.IsSucceed = false;
                result.AddError($"Password is incorrect");
                return result;
            }

            result.IsSucceed = true;
            return result;
        }


        public ProcessResult Register(string email, string password, string confirmPassword, string fullname, string groupNo)
        {
            ProcessResult result = new ProcessResult();

            if (password != confirmPassword)
            {
                result.AddError("Passwords don't mastch");
                result.IsSucceed = false;
                return result;
            }

            if (FindByEmail(email) != null)
            {
                result.AddError("Email has already been taken");
                result.IsSucceed = false;
                return result;
            }


            Student student = new Student
            {
                Email = email,
                Password = password,
                FullName = fullname,
                GroupNo = groupNo
            };

            Array.Resize(ref _students, _students.Length + 1);
            Students[Students.Length - 1] = student;

            result.IsSucceed = true;
            return result;
        }

        public Student FindByEmail(string email)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Email == email)
                {
                     return Students[i];
                }
            }

            return null;
        }
    }
}
