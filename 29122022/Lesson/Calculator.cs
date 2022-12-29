using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal static class Calculator
    {
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Pow(int num,int pow)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
