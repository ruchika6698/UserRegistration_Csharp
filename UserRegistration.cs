using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration : Validation
    {
        private static readonly object Userinput;
   
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
        public string ValidateFirstName(string FirstName)
        {
            var expr = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expr, stringToMatch: FirstName);
        }
        //method to Validate Last Name
        public string ValidateLastName(string FirstName)
        {
            var expr = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expr, stringToMatch: FirstName);
        }
        //method to validate Email
        public string ValidateEmail(string Email)
        {
            var expr = "^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$";
            return checkMatch(expr, stringToMatch: Email);
        }
        //method to validate Mobile Number
        public string ValidateMobileNumber(string MobileNumber)
        {
            var expr = "^[0-9]{2}[ ][0-9]{10}$";
            return checkMatch(expr, stringToMatch: MobileNumber);
        }

        public string ValidatePassword(string Password)
        {
            var expr = "^[a-zA-Z0-9]*[@#$&*_+-]{1}[a-zA-Z0-9]*$";
            return checkMatch(expr, stringToMatch: Password);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Filled the Details of User and Register:");

            UserRegistration userRes = new UserRegistration();

            Console.WriteLine($"FirstName {userRes.ValidateFirstName(FirstName: (string)Userinput.inputFirstName())}");
            Console.WriteLine($"LastName {userRes.ValidateLastName(LastName: (string)Userinput.inputLastName())}");
            Console.WriteLine($"Email {userRes.ValidateEmail(Email: (string)Userinput.inputEmail())}");
            Console.WriteLine($"MobileNumber {userRes.ValidateMobileNumber(MobileNumber: (string)Userinput.inputMobileNumber())}");
            Console.WriteLine($"Password {userRes.ValidatePassword(Password: (string)Userinput.inputPassword())}");
        }
    }
}
