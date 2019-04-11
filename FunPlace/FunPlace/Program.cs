using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int Userchoice = 0;
            int TotalNo = 0;
            int i = 1;
            string inMood;
            string noPeople;
            bool success;
            while (i > 0)
            {
                Console.WriteLine("Hello User, What are you in the mood for? 1- Action , 2- Chill Times, 3- Danger, 4-Good Food");
                inMood = Console.ReadLine();
                //Userchoice = double.Parse(inMood);
                bool parseSuccess = int.TryParse(inMood, out Userchoice);
                if (Userchoice == 1 || Userchoice == 2 || Userchoice == 3 || Userchoice == 4) { i = 0; }
                else
                {
                    Console.WriteLine("Please enter the valid choice.... ");
                }
            }
           
            switch (Userchoice)
            {
                case 1:
                    Console.WriteLine("You should go to Stock car Racing");
                    break;
                case 2:
                    Console.WriteLine("You should go to Hiking");
                    break;
                case 3:
                    Console.WriteLine("You should go to Skydiving");
                    break;
                case 4:
                    Console.WriteLine("You should go to Taco Bell");
                    break;
                default:
                    Console.WriteLine("Input was not understood {0}", Userchoice);
                    break;
            }
           
            do
            {
                Console.WriteLine("How many people are you bringing with you?");
                
                noPeople = Console.ReadLine();
                //TotalNo = int.Parse(Console.ReadLine());
                success = int.TryParse(noPeople, out TotalNo);

                if (TotalNo < 0 || (TotalNo % 1) > 0 || !success)
                {
                    Console.WriteLine("Please enter valid number");
                }
               
            } while (TotalNo < 0 || (TotalNo % 1) > 0 || !success);
                if (TotalNo == 0)
                {
                    Console.WriteLine("You should travel in sneakers");
                }
                else if (TotalNo >= 1 && TotalNo <= 4)
                {
                    Console.WriteLine("You should travel in a sedan");
                }
                else if (TotalNo >= 5 && TotalNo <= 10)
                {
                    Console.WriteLine("You should travel in a Volkswagen bus");
                }
                else if (TotalNo >= 11)
                {
                    Console.WriteLine("You should travel in an areoplane");
                }
                else
                {
                    Console.WriteLine("Enter valid number of people travelling with you.");
                }
       
            Console.WriteLine("GoodBye!");
            Console.ReadLine();
        }
    }
}
