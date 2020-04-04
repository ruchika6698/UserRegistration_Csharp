using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    class Validation
    {
        interface Validate
        {
            string checkMatch(string expression, string stringToCheck);
            string ValidateFirstName(string FirstName);
            string ValidateLastName(string LastName);
            string ValidateEmail(string Email);
            string ValidateMobileNumber(string MobileNumber);
            string ValidatePassword(string Password);

        }
    }
}
