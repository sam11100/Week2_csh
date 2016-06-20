using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {



        
            int rand;
            string playAgain ="Y";
            int inputNumber;

      
               


            while (playAgain == "Y") {
                Random rnd = new Random();
                 rand = rnd.Next(1, 11);
           
                do
                {
                    Console.WriteLine("Guess a number between 1-10?");
                    inputNumber = Convert.ToInt32(Console.ReadLine());

                    if (inputNumber > rand)
                    {
                        Console.WriteLine("the random number is :" + rand);
                        Console.WriteLine("The number is less then your input!");
                    }
                    else if (inputNumber < rand)
                    {
                        Console.WriteLine("the random number is :" + rand);
                        Console.WriteLine("The number is greater then your input!");

                    }
                    else
                    {
                        Console.WriteLine("Well Done!! You have guessed the number correctly!");

                    }


                    




                } while (rand != inputNumber);
            Console.WriteLine("Type Y or N to play again or stop.");
            playAgain = (Console.ReadLine()).ToUpper();
            }
        }
    }
}
