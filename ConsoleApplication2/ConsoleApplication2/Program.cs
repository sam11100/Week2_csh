using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("People that are running for presedency: Donald Trump,Hilery Clinton,Bernie Sownders");
           string candidate =  (Console.ReadLine()).ToUpper();





            switch (candidate)
            {
                case "DONALD TRUMP":
                case "DONALD":
                case "TRUMP":

                    Console.WriteLine("WELL BUDDY IF YOU ARE AMERICAN THEN !! HAHA <--in Nelson's voice from Simpson");
                    break;

                case "HILERY CLINTON":
                case "HILERY":
                case "CLINTON":

                    Console.WriteLine("WELL THEN YOU MUST HATE MONICA LEWINSKY");
                    break;


                case "BERNIE SWONDERS":
                case "BERNIE":
                case "SWONDERS":


                    Console.WriteLine("WELL THEN YOU MUST LOVE OLD PEOPLE!!");
                    break;
                default:
                    Console.WriteLine("DUDE WHAT YOU SMOKIN!!!");
                    break;
            }




        }
    }
}
