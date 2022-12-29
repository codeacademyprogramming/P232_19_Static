using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class ProcessResult
    {
        public bool IsSucceed;
        public string[] Errors = new string[0];

        public void AddError(string message)
        {
            Array.Resize(ref Errors, Errors.Length + 1);
            Errors[Errors.Length - 1] = message;
        }

        public void ShowErrors()
        {
            for (int i = 0; i < Errors.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Errors[i]}");
            }
        }
    }
}
