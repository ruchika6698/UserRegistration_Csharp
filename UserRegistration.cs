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
                return "valid";
            }
            else
            {
                return "invalid";
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

        static void Main(string[] args)
        {
            Console.WriteLine("Filled the Details of User and Register:");

            UserRegistration userRes = new UserRegistration();

            string FirstName = UserInput.inputFirstName();
            Console.WriteLine($"First name {userRes.validateFirstName(FirstName)}");

            string LastName = UserInput.inputLastName();
            Console.WriteLine($"First name {userRes.validateLastName(LastName)}");
        }
    }
}
