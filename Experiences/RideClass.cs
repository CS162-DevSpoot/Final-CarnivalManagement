using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement.Experiences
{
    public class RideClass: ExperienceClass
    {
        public string HightRequirement { get; set; }

        //Overriding our display method, to more accurately describe ticket prices.
        public override void displayTicketPrice()
        {
            MessageBox.Show($"This Ride Cost {TicketPrice} Tickets.");
        }
    }
}
