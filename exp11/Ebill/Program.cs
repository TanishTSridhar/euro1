using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ebill
{ 
    class Program
    {

        public static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Consumers\n");
            n = Convert.ToInt32(Console.ReadLine());

            consumer[] con = new consumer[n];
           


            for (int i = 0; i < n; i++)
            {
                con[i] = new consumer();
                Console.WriteLine("Enter Consumer ID \n");
                con[i].ConID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Consumer Name \n");
                con[i].ConName = Console.ReadLine();

                Console.WriteLine("Enter Per unit Cost \n");
                con[i].Perunit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Total units Used \n");
                con[i].Totalunit = Convert.ToInt32(Console.ReadLine());

                con[i].Totalamt = con[i].Totalunit * con[i].Perunit;

                Console.WriteLine("Enter Due Date \n");
                con[i].DueDate = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();

                con[i].BillNo = r.Next();


            }

        

            foreach (consumer item in con)
            {
                Console.WriteLine("BILL \n");
                Console.WriteLine("Bill number : " + item.BillNo + "\n Consumer ID: " + item.ConID + "\n Total Amount : " + item.Totalamt + "\n Due date : " + item.DueDate + " \n");
            }

            Console.Read();


        }

       
    }

    class consumer
    {
        public int ConID { get; set; }
        public string ConName { get; set; }
        public int Perunit { get; set; }
        public int Totalunit { get; set; }
        public int Totalamt { get; set; }

        public int DueDate { get; set; }

        public int BillNo { get; set; }
    }

}
