using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_OddOrEven
{
    class Program
    {
        public static void EvenNum(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Number : " + i);
                Thread.Sleep(1000);



            }

        }



        public static void OddNum(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine("Odd Number : " + i);
                Thread.Sleep(1500);
            }

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Multi Threading \n");
            Thread EvenNumb = new Thread(() => Program.EvenNum(n));
            Thread OddNumb = new Thread(() => Program.OddNum(n));

            EvenNumb.Start();
            OddNumb.Start();
           


            Console.WriteLine("Asyn Threading \n");
            Task EvenTask = new Task(() => Program.EvenNum(n));
            Task OddTask = new Task(() => Program.OddNum(n));



            EvenTask.Start();
            OddTask.Start();
            Console.WriteLine("Asyn start"); 
            Console.ReadLine();

        }
    }
}
