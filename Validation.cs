using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    class Validation
    {
        interface Validator
        {
            string checkMatch(string exp, string stringToCheck);
            string ValidateFirstName(string FirstName);
            string ValidateLastName(string LastName);
            string ValidateEmail(string Email);
            string ValidateMobileNumber(string MobileNumber);
            string ValidatePassword(string Password);

        }
    }
}
