using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration : Validation
    {
        private static readonly object UserInput;
        private static string FirstName;

        // interface method to match
        public string checkMatch(string exp, string stringToMatch)
        {
            var match = Regex.Match(stringToMatch, exp, RegexOptions.None);
            if (match.Success)
            {
                return "Details are Valid";
            }
            else
            {
                return "Invalid Data or Format";
            }
        }

        //method to Validate First Name
        public string validateFirstName(string FirstName)
        {
            var expr = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expr, stringToMatch: FirstName);
        }
        //method to Validate Last Name
        public string validateLastName(string FirstName)
        {
            var expr = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expr, stringToMatch: FirstName);
        }
        //method to validate Email
        public string validateEmail(string Email)
        {
            var expr = "^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$";
            return checkMatch(expr, stringToMatch: Email);
        }
        //method to validate Mobile Number
        public string validateMobileNumber(string MobileNumber)
        {
            var expr = "^[0-9]{2}[ ][0-9]{10}$";
            return checkMatch(expr, stringToMatch: MobileNumber);
        }

        public string validatePassword(string Password)
        {
            var expr = "^[a-zA-Z]{8,15}$";
            return checkMatch(expr, stringToMatch: Password);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Filled the Details of User and Register:");

            UserRegistration userRes = new UserRegistration();

            string FirstName = UserInput.inputFirstName();
            string value = $"First name {userRes.validateFirstName(FirstName)}";
            Console.WriteLine(value);

            string LastName = UserInput.inputLastName();
            Console.WriteLine($"Last name {userRes.validateLastName(LastName)}");

            string Email = UserInput.inputEmail();
            Console.WriteLine($"Email {userRes.validateEmail(Email)}");

            string MobileNumber = UserInput.inputMobileNumber();
            Console.WriteLine($"MobileNumber {userRes.validateEmail(MobileNumber)}");

            string Password = UserInput.inputPassword();
            Console.WriteLine($"Password {userRes.validateEmail(Password)}");
        }
    }
}
