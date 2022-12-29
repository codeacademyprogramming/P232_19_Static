using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class UserAlreadyExistException:Exception
    {
        public UserAlreadyExistException(string message):base(message)
        {

        }
    }
}
