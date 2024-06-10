using CS162_Final_CarnivalManagement.Experiences;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement.Management
{
    public class CarnivalClass : IManagementSystem
    {
        public Dictionary<string, RideClass> Rides = new Dictionary<string, RideClass>();
        public Dictionary<string, BoothClass> Booths = new Dictionary<string, BoothClass>();
        public Dictionary<int, VisitorClass> Vistors = new Dictionary<int, VisitorClass>();

        public decimal TicketCost { get; set; }
        public int totalSoldTickets { get; set; }

        public CarnivalClass()
        {
            totalSoldTickets = 0;
            TicketCost = 1m;
        }

        public CarnivalClass(decimal ticketCost)
        {
            totalSoldTickets = 0;
            TicketCost = ticketCost;
        }

        public void saleTickets(int numberToSell)
        {
            totalSoldTickets += numberToSell;
        }
        public void displayTotalTickets()
        {
            MessageBox.Show($"Total Tickets Sold: {totalSoldTickets}.");
        }
    }
}
