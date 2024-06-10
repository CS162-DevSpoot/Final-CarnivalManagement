using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement.Management
{
    public class VisitorClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Tickets { get; set; } 

        public void spendTickets(int numberToSpend)
        {
            if(numberToSpend > Tickets) { return; } //Make sure the visiot has enough tickets.

            Tickets -= numberToSpend;
        }
    }
}
