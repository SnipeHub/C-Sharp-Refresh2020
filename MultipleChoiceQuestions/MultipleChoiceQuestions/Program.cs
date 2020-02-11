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
            //string Readback;
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            name = name.ToLower();

            if (name == "")
            {
                NothingEntered();
                name = Console.ReadLine();
                name = name.ToLower();
            }

            Console.WriteLine("How old are you? ");
            var age = Console.ReadLine();

            if (age == "")
            {
                NothingEntered();
                age = Console.ReadLine();
            }

            Console.WriteLine("What month were you born in? ");
            var born = Console.ReadLine();
            born = born.ToLower();

            if (born == "")
            {
                NothingEntered();
                born = Console.ReadLine();
                born = born.ToLower();
            }

            if (born != "more")
            {
                Console.WriteLine("Hint: next time enter 'more' for the month!");
            }

            // option output 1
            //entered info output
            //Readback = $"Your name is {name}, you are {age} years old and you were born in the month of {born}";
            //Console.WriteLine(Readback);

            // Pause screen, prompt for key press to exit
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();

            // option output 2
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your age is: {age}");
            //Console.WriteLine($"Your born in: {born}");


            if (born == "more")
            {
                Console.WriteLine("You entered the secret hint!");
            }
            else if (born != "more")
            {
                Console.WriteLine($"Your born in: {born}");
            }


            if (born == "november")
            {
                Console.WriteLine("Your star sign is either a Libra or Ophiuchus");
            }
            if (born == "december")
            {
                Console.WriteLine("You star sign is most likely Ophiuchus or Sagittarius");
            }
            else if (born == "more")
            {
                Console.WriteLine("Did you know that there are actually 14 constellations?");
            }


        }

        static void NothingEntered()
        {
            Console.WriteLine("You did not enter anything, please try again");
        }
    }
}
