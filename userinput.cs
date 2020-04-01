using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration
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

        public static string MobileNumber()
        {
            Console.Write("Enter Your Mobile Number : ");
            return Console.ReadLine();
        }

        public static string Password()
        {
            Console.Write("Enter Your Password: ");
            return Console.ReadLine();
        }
    }
}
