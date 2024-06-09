using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement.Experiences
{
    public class BoothClass: ExperienceClass
    {
        public string Prize { get; set; }

        //Overriding our display method, to more accurately describe ticket prices.
        public override void displayTicketPrice()
        {
            MessageBox.Show($"This Booth Cost {TicketPrice} Tickets.");
        }
    }
}
