using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceQuestions
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Readback;
            Console.WriteLine("What is your name? ");
            var name = TryAnswer();

            Console.WriteLine("How old are you? ");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in? ");
            var month = TryAnswer();
            month = month.ToLower();

            if (month != "more")
            {
                Console.WriteLine("Hint: next time enter 'more' for the month!");
            }

            // option output 1
            //entered info output
            //Readback = $"Your name is {name}, you are {age} years old and you were month in the month of {month}";
            //Console.WriteLine(Readback);

            // Pause screen, prompt for key press to exit
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();

            // option output 2
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your age is: {age}");
            //Console.WriteLine($"Your month in: {month}");


            if (month == "more")
            {
                Console.WriteLine("You entered the secret hint!");
            }
            else if (month != "more")
            {
                Console.WriteLine($"Your born in: {month}");
            }


            if (month == "november")
            {
                Console.WriteLine("Your star sign is either a Libra or Ophiuchus");
            }
            if (month == "december")
            {
                Console.WriteLine("You star sign is most likely Ophiuchus or Sagittarius");
            }
            else if (month == "more")
            {
                Console.WriteLine("Did you know that there are actually 14 constellations?");
            }


        }

        // changed into a function return
        // when void is used, there is no return, when a string is used we can do a return
        /// <summary>
        /// This return function will tell the user to enter something if nothing is typed in when a question is asked. 
        /// </summary>
        /// <returns></returns>
        static string TryAnswer()
        {
            var answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine("You did not enter anything, please try again");
                return Console.ReadLine(); // When a function retuns, it ends, so make sure the return is your last line in the function. Nothing after this will work.
            }
            return answer;
        }
    }
}
