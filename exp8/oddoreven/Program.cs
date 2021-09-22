using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oddoreven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n ");
            Console.WriteLine("Sequential \n ");

            for (int i = 0; i < num; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine($"Even Number: {i}, Thread = { Thread.CurrentThread.ManagedThreadId}");
                }

                else
                {
                    Console.WriteLine($"Odd Number: {i}, Thread = { Thread.CurrentThread.ManagedThreadId}");
                }
            }

            Console.WriteLine(" \n ");
            Console.WriteLine("Parallel \n ");

            Parallel.For(1, num, i =>
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Even number : { i}, Thread :  { Thread.CurrentThread.ManagedThreadId} ");
                else
                    Console.WriteLine($"Odd number : { i}, Thread :  { Thread.CurrentThread.ManagedThreadId} ");
                Thread.Sleep(500);
            }  );

            Console.ReadLine();
        }
    }
}
