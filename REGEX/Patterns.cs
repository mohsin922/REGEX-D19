using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class Patterns
    {

        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_Number = "^[0-9]{2}[ ][6-9][0-9]{9}$";
        public static string Regex_Password = "^((?=.*[A-Z])(?=.{8,}))";

        public static bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }


        public static void checkFirstName(string FirstName)
        {
            if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
            {
                Console.WriteLine("Enter valid First name. It should Start with capital letters and minimum 3 letters!");
            }
        }


        public static bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }

        public static void checkLastName(string LastName)
        {
            if (Regex.IsMatch(LastName, Regex_LastName) == false)
            {
                Console.WriteLine("Enter valid Last name. It should Start with capital letters and minimum 3 letters!");
            }
        }

        public static bool validateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

        public static void checkemail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email) == false)
            {
                Console.WriteLine("Enter valid email address!");
            }
        }

        public static bool validatenumber(string number)
        {
            return Regex.IsMatch(number, Regex_Number);
        }

        public static void checknumber(string number)
        {
            if (Regex.IsMatch(number, Regex_Number) == false)
            {
                Console.WriteLine("Enter valid Mobile Number!");
            }
        }
        public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

        public static void checkPassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == false)
            {
                Console.WriteLine("Enter valid password. It should contain minimum 8 character," +
                    "atleast one upper case character");
            }
        }

    }
}