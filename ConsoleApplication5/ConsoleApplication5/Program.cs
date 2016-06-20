using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] myArays = new int[5];
            for (int i = 0; i < myArays.Length; i++)
            {
                Console.WriteLine("Write five numbers");
                myArays[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i +": "+ myArays[i]);
                Console.WriteLine(myArays[i]);
                sum += myArays[i];

               
               
            }

            int average = sum / myArays.Length;
            Console.WriteLine(average);
        }
    }
}
