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

            Console.Write("Enter your email addresss: ");
            string email = Console.ReadLine();
            Patterns.checkemail(email);

            Console.Write("Enter your mobile number: ");
            string number = Console.ReadLine();
            Patterns.checknumber(number);

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Patterns.checkPassword(password);
        }
    }
}