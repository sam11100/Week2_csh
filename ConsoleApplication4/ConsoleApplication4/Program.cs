using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine("Your Dinner is ready " + sevenDwarves[i]);
            }

            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("Your drink is ready " + i);
            }

        }
    }
}
