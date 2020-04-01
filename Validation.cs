using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    class Validation
    {
        interface IValidation
        {
            string checkMatch(string exp, string stringToCheck);
            string validateName(string FirstName);

        }
    }
}
