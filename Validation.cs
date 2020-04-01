using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
{
    class Validation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Filled the Details of User and Register:");

            UserRegistration userRes = new UserRegistration();

            string FirstName = UserInput.inputFirstName();
            string value = $"First name {userRes.validateFirstName(FirstName)}";
            Console.WriteLine(value);

            string LastName = UserInput.inputLastName();
            Console.WriteLine($"Last name {userRes.validateLastName(LastName)}")

            string Email = Usernput.inputEmail();
            Console.WriteLine($"Email {userRes.validateEmail(Email)}");
        }
        
    }
}
