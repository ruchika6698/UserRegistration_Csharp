using System;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UserRegistration : Validation
    {
        /// <summary>
        /// Class for User Inputs
        /// </summary
        class Userinput
        {
            /// <summary>
            /// Method to take First Name from User
            /// </summary
            public static string inputFirstName()
             {
                Console.Write("Enter Your First name : ");
                return Console.ReadLine();
             }

            /// <summary>
            /// Method to take Last Name from User
            /// </summary
            public static string inputLastName()
             {
                Console.Write("Enter Your Last name : ");
                return Console.ReadLine();
             }

            /// <summary>
            /// Method to take Email from User
            /// </summary
            public static string inputEmail()
             {
                Console.Write("Enter Your Email Address : ");
                return Console.ReadLine();
             }

            /// <summary>
            /// Method to take Mobile Number from User
            /// </summary
            public static string inputMobileNumber()
            {
                Console.Write("Enter Your Mobile Number : ");
                return Console.ReadLine();
            }

            /// <summary>
            /// Method to take Password from User
            /// </summary
            public static string inputPassword()
            {
                Console.Write("Enter Your Password: ");
                return Console.ReadLine();
            }
        }

        /// <summary>
        /// interface method to match
        /// </summary
        public string checkMatch(string expression, string stringToMatch)
        {
            Match match = Regex.Match(stringToMatch, expression, RegexOptions.None);
            if (match.Success)
            {
                return "is valid";
            }
            else
            {
                return "Invalid Data or Format";
            }
        }

        /// <summary>
        /// interface method to Validate First Name
        /// </summary
        public string ValidateFirstName(string FirstName)
        {
            string expression = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expression, stringToMatch: FirstName);
        }
        /// <summary>
        /// interface method to Validate Last Name
        /// </summary
        public string ValidateLastName(string LastName)
        {
            string expression = "^[A-Z][a-zA-Z]{3,15}$";
            return checkMatch(expression, stringToMatch: LastName);
        }

        /// <summary>
        /// interface method to Validate Email
        /// </summary
        public string ValidateEmail(string Email)
        {
            string expression = "^[a-zA-Z0-9]{1,}([.]?[-]?[+]?[a-zA-Z0-9]{1,})?[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-z]{2,3}([.]?[a-z]{2})?$";
            return checkMatch(expression, stringToMatch: Email);
        }

        /// <summary>
        /// interface method to Validate Mobile Number
        /// </summary
        public string ValidateMobileNumber(string MobileNumber)
        {
            string expression = "^[0-9]{2}[ ][0-9]{10}$";
            return checkMatch(expression, stringToMatch: MobileNumber);
        }

        /// <summary>
        /// interface method to Validate Password
        /// </summary
        public string ValidatePassword(string Password)
        {
            string expression = "^[a-zA-Z0-9]*[@#$&*_+-]{1}[a-zA-Z0-9]*$";
            return checkMatch(expression, stringToMatch: Password);
        }

        /// <summary>
        /// main method, program execution 
        /// </summary
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
