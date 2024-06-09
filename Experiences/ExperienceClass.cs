using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement
{
    public class ExperienceClass
    {
        public string Name { get; set; }
        public int Capcitity { get; set; }
        public int TicketPrice { get; set; }

        //Allowing our method that show the ticket prices to be overriden, not all require to be ovveriden, such as Concerts.
        public virtual void displayTicketPrice()
        {
            MessageBox.Show($"This Experience Cost {TicketPrice} Tickets");
        }

        public string renderTicketPrice()
        {
            return $"{TicketPrice} Tickets";
        }

    }
}
