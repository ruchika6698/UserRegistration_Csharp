using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration : Validation
    {
        class Userinput
        {
             public static string inputFirstName()
             {
                Console.Write("Enter Your First name : ");
                return Console.ReadLine();
             }

             public static string inputLastName()
             {
                Console.Write("Enter Your Last name : ");
                return Console.ReadLine();
             }

             public static string inputEmail()
             {
                Console.Write("Enter Your Email Address : ");
                return Console.ReadLine();
             }

            public static string inputMobileNumber()
            {
                Console.Write("Enter Your Mobile Number : ");
                return Console.ReadLine();
            }

            public static string inputPassword()
            {
                Console.Write("Enter Your Password: ");
                return Console.ReadLine();
            }
        }
        // interface method to match
        public string checkMatch(string expression, string stringToMatch)
        {
           var match = Regex.Match(stringToMatch, expression, RegexOptions.None);
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
            var expression = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expression, stringToMatch: FirstName);
        }
        //method to Validate Last Name
        public string ValidateLastName(string LastName)
        {
            var expression = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expression, stringToMatch: LastName);
        }
        //method to validate Email
        public string ValidateEmail(string Email)
        {
            var expression = "^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$";
            return checkMatch(expression, stringToMatch: Email);
        }
        //method to validate Mobile Number
        public string ValidateMobileNumber(string MobileNumber)
        {
            var expression = "^[0-9]{2}[ ][0-9]{10}$";
            return checkMatch(expression, stringToMatch: MobileNumber);
        }

        public string ValidatePassword(string Password)
        {
            var expression = "^[a-zA-Z0-9]*[@#$&*_+-]{1}[a-zA-Z0-9]*$";
            return checkMatch(expression, stringToMatch: Password);
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
