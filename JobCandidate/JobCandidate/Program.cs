using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:    // default is used like an else
                    Console.WriteLine("Senior");
                    break;
            }

        }
    }
}
