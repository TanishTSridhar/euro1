using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp5
{
    class Program
    {

        public static void even()
        {
            foreach (int i in num)
            {
                if(i % 2 == 0)
            {
                    int result = result + i;
            }

            }


        }
        static void Main(string[] args)
        {
            List<int> num = new List<int>();

            Console.WriteLine("ENTER 10 NUMBERS");
            for (int i = 0; i < 10; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                num.Add(x);
            }
           
            
        }
    }
}
