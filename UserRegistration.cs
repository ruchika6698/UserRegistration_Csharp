using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration : Validation
    {
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
        public string validateName(string FirstName)
        {
            var expr = "^[A-Z][a-zA-Z]{3,15}$";
            return this.checkMatch(expr, FirstName);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Filled the Details of User and Register");


        }
    }
}
