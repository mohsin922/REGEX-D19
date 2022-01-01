using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace REGEX
{
    class Patterns
    {
        public void Pattern()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string s = @"^[A-Z]{1}[a-z]{3,}$";
            Regex Name = new Regex(s);
            Console.WriteLine($"Name is: {Name.Match(name)}");
        }
    }
}