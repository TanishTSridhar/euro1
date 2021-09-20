using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh
{
    class bookTickets
    {
        public void TicketBooking()
        {
            
            Console.WriteLine("WELCOME OFFLINE TICKET BOOKING ");
            Console.WriteLine("******************************\n");
            Console.WriteLine("Your Nearest center for booking is in Indranagar,Bangalore \n ");
        }

    }

    class bookETicket : bookTickets
    {
        public void ETicket()
        {
            
            Console.WriteLine("WELCOME TO ONLINE TICKET BOOKING");
            Console.WriteLine("***************************\n");
            Console.WriteLine("Please enter your Details\n ");
        }
    }

    class viewMaintenance : bookETicket
    {
        public void Maintenance()
        {
            Console.WriteLine("Maintainance details of Aircrafts \n");
            Console.WriteLine("Name of Aircraft \t Aircraft Number \t Maintenance Check");
        }

    }
}
