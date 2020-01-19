using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "My String"; //The variable can be called anything you like
            int hold = 1;

            Console.WriteLine(a);

            if (hold > 0)
            {
                Console.WriteLine("The interger is greater than zero");
            }
            else
            {
                Console.WriteLine("The interger is not greater than zero");
            }
        }
    }
}
