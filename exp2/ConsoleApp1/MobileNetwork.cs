using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class MobileNetwork
    {
        public void readfile()
        {
            FileStream fs = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp2\ConsoleApp1\exp2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Mobile Network Performance");
            Console.WriteLine("*************************");
            Console.WriteLine("Source\t   Destination\t  Date\t      Call-Status");

            while (sr.Peek() > 0)
            {

                string line = sr.ReadLine();
                if (line.Contains(":"))
                {
                    string[] details = line.Split(':');
                    Console.Write(details[1] + "    ");
                }


            }
        }
    }
}

