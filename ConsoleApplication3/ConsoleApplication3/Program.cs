using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string gameEnd = "Y";
            string ans1;
            string ans2;
            int attempts;
            string giveUp = "NOPASS";
            int score = 0;
            int attempts2 = 3;



            while (gameEnd == "Y")
            {
                 attempts = 3;
                Console.WriteLine("Welcome to the riddle game. Press Enter to start!!");
                Console.ReadLine();
                
                while ((giveUp == "NOPASS") && (attempts >= 1))
                {


                    

                    Console.WriteLine("R1 :What has a foot but no legs?");
                    ans1 = Console.ReadLine().ToUpper();

                    if ((ans1 == "SNAILS") || (ans1 == "SNAIL"))
                    {
                        score++;
                        Console.WriteLine("You are Right!!");
                        giveUp = "SKIP";

                    }
                    else
                    {
                        attempts--;
                        Console.WriteLine("Sorry Wrong Answer!!Try again you have got " + attempts + " attempts left. Type pass to skip or enter to try again");
                        giveUp = (Console.ReadLine()).ToUpper();
                        if ((giveUp == "PASS") || (attempts == 0)) 
                        {
                            giveUp = "SKIP";
                        }
                        else
                        {
                            giveUp = "NOPASS";
                        }



                    }
                }

                do
                {


                    Console.WriteLine("R2: Poor people have it. Rich people need it. If you eat it you die.");
                    ans2 = Console.ReadLine().ToUpper();

                    if (ans2 == "NOTHING")
                    {
                        score++;
                        Console.WriteLine("You are Right!!");
                        giveUp = "SKIP";
                    }
                    else
                    {
                        attempts2--;
                        Console.WriteLine("Sorry Wrong Answer!!Try again you have got " + attempts2 + " attempts left. Type pass to skip or enter to try again");
                        giveUp = (Console.ReadLine()).ToUpper();
                        if ((giveUp == "PASS") || (attempts2 == 0))
                        {
                            giveUp = "SKIP";
                        }
                        else
                        {
                            giveUp = "NOPASS";
                        }

                    }





                } while ((giveUp == "NOPASS") && (attempts != 0));





                Console.WriteLine("Type replay to start again or stop to leave.");
                 gameEnd = Console.ReadLine().ToUpper();
                if (gameEnd == "REPLAY")
                {
                    gameEnd = "Y";
                }
                else
                {
                    gameEnd = "N";
                }



               }







        }
    }
}
    

