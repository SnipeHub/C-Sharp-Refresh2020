using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLoopCounting
{
    class Program // Count from 1 to 10 then back to 1, and repeat 5 times, do not use if statements
    {
        static void Main(string[] args)
        {
            for (int repeat = 1; repeat <= 5; repeat++)
            {
                // counting up
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // counting back down
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
