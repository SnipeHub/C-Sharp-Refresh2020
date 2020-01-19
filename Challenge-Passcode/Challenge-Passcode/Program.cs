using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge: Check that the input matches the passcode "secret"
            // Let user know he/she is authenticated

            var passCheck = ""; // needs to be declared and enter nothing since we not asking for password yet.
            while (passCheck != "secret")
            {
                Console.WriteLine("Hi Mark, please enter your password");
                Console.Write("Password > ");
                passCheck = Console.ReadLine(); // we must get rid of "var" here as we have already declared it
                Console.WriteLine("Press a enter to continue...");
                Console.ReadKey();

                if (passCheck != "secret")
                {
                    Console.WriteLine("Password Incorrect, Authentication failed!");
                }
            }

            Console.WriteLine("Welcome Mark!");
            Console.WriteLine("Authentication Succesful!");
        }
    }
}
