using System;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName;
            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();
            Patterns.checkFirstName(FirstName);

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            Patterns.checkLastName(LastName);
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}