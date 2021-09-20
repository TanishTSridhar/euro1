using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh
{
    class Program
    {
        static void Main(string[] args)
        {
            viewMaintenance option = new viewMaintenance();
            Console.WriteLine(" 1) Offline Ticket Booking \n 2) Online Ticket Booking \n 3) View Maintenance Details\n");
            Console.WriteLine("Please Enter your option..");
            int n = Convert.ToInt32(Console.ReadLine());


            if (n == 1)

                // Offline Ticket Booking
                option.TicketBooking();

            else if (n == 2)

                // Online Ticket Booking Page
                option.ETicket();

            else if (n == 3)

                // Maintenance Details
                option.Maintenance();
            else
                Console.WriteLine("Invalid Option, Please enter a valid option");

            Console.Read();

        }
    }
}
