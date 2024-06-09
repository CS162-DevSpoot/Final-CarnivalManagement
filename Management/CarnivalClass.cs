using CS162_Final_CarnivalManagement.Experiences;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement.Management
{
    public class CarnivalClass : IManagementSystem
    {
        public Dictionary<string, RideClass> Rides { get; set; }
        public Dictionary<string, BoothClass> Booths { get; set; }

        public int TicketCost { get; set; }
        public int totalSoldTickets { get; set; }

        public CarnivalClass()
        {
            totalSoldTickets = 0;
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
