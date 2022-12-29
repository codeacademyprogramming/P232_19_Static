using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal interface IUniversityPortal
    {
        Student[] Students { get; }
        ProcessResult Login(string email, string password);
        ProcessResult Register(string email, string password, string confirmPassword, string fullname, string groupNo);
    }
}
