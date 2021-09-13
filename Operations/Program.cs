using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, value3, value4;
            float value5, value6, value7;
            Console.WriteLine("Enter value1:");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value2:");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 + value2;
            value4 = value1 - value2;
            value5 = value1 * value2;
            value6 = value1 / value2;
            value7 = value1 % value2;
            Console.WriteLine("Addition:" + value3);
            Console.WriteLine("Subtraction:" + value4);
            Console.WriteLine("Multiplication:" + value5);
            Console.WriteLine("division:" + value6);
            Console.WriteLine("Mod:" + value7);
            Console.Read();
        }
    }
}
