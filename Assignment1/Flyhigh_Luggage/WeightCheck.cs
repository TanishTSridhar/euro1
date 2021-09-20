using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh_Luggage
{
    class WeightCheck
    {
        public int FirstClassWeight = 50;
        public int BusinessClassWeight = 40;
        public int EconomyClassWeight = 20;

        public void CheckWeight(int option, int w)
        {
            if (option == 1)
            {
                if (w <= FirstClassWeight)
                    Console.WriteLine("Have a Safe and Happy Journey in Frist Class !!!! ");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit of 50 Kgs.");
                    Console.WriteLine("You need to Pay $ " + (2 * (w - FirstClassWeight)) + " for the extra Luggage.");
                }
            }
            else if (option == 2)
            {
                if (w <= BusinessClassWeight)
                    Console.WriteLine("Have a Safe and Happy Journey in Business Class !!!! ");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit of 40 Kgs.");
                    Console.WriteLine("You need to Pay $ " + (2 * (w - BusinessClassWeight)) + " for the extra Luggage.");
                }
            }
            else if (option == 3)
            {
                if (w <= EconomyClassWeight)
                    Console.WriteLine("Have a Safe and Happy Journey in Economy Class !!!! ");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit of 20 Kgs.");
                    Console.WriteLine("You need to Pay $ " + (2 * (w - EconomyClassWeight)) + " for the extra Luggage.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice.... Please Enter a Vaild option");
                
            }

            Console.ReadLine();
        }
    }
}
