using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Payer 5");
            d.Add(2, "Payer 1");
            d.Add(3, "Payer 3");
            d.Add(4, "Payer 2");
            d.Add(5, "Payer 4");
           

         

            Console.WriteLine("Number of players : " + d.Count);
            string temp = d[1];
            d[1] = d[5];
            d[5] = temp;
            foreach (var i in d)
            {
                Console.WriteLine("Place : " + i.Key + ", Name : " + i.Value);
            }
            Console.WriteLine();
            Console.WriteLine("1st Plave: " + d[1]);

            Console.WriteLine("Clearing all the data from Dictionary.");
            d.Clear(); //Clearing all the data from Dictionary

            Console.ReadLine();
        }
    }
}
