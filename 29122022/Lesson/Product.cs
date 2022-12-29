using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        static Product()
        {
            Counter = 100;
        }

        public Product()
        {
            Counter++;
        }
        public static int Counter;
        private string _name;
        public double Price;

        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }

        public static bool CheckName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name) && name.Length>=2 && (char.IsDigit(name[0]) || char.IsUpper(name[0])))
            {
                return true;
            }
            return false;
        }

        public string GetInfo()
        {
            return $"Name: {Name} - Price:{Price}";
        }

    }
}
