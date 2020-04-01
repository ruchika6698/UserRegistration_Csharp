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
        public string validateEmail(string Email)
        {
            var expr = "^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$";
            return checkMatch(expr, stringToMatch: Email);
        }
    }
}
