using CS162_Final_CarnivalManagement.Experiences;
using CS162_Final_CarnivalManagement.Management;
using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement
{
    public partial class VisitorDemoForm : Form
    {
        public VisitorDemoForm(CarnivalClass carnival)
        {
            carnivalOS = carnival;
            InitializeComponent();
        }

        CarnivalClass carnivalOS = null;

        bool debounce = false; // debounce var to make sure our list updates don't trigger our change selected index event.
        private void updateExperiences()  // updating experinces, loading rides first than booths.
        {
            debounce = true;
            experiencesListBox.Items.Clear();
            foreach (var ride in carnivalOS.Rides) // looping through each ride.
            {
                experiencesListBox.Items.Add(ride.Value.Name);
            }

            foreach (var booth in carnivalOS.Booths) // looping through each booth.
            {
                experiencesListBox.Items.Add(booth.Value.Name);
            }
            debounce = false;
        }

        private void updateVisitors() //metthod to load all visiots.
        {
            foreach (var visitor in carnivalOS.Vistors) // looping through each visiot.
            {
                visiotListBox.Items.Add(visitor.Value.Name);
            }
        }

        private void VisitorDemoForm_Load(object sender, System.EventArgs e)
        {
            if(carnivalOS.Rides.Count == 0 && carnivalOS.Booths.Count == 0 )
            {
                MessageBox.Show("There are no expericnes to load.");
                return;
            }
            if(carnivalOS.Vistors.Count == 0)
            {
                MessageBox.Show("There are no visiots to load.");
                return;
            }
            updateExperiences();
            updateVisitors();
        }

        RideClass selectedRide = null;
        BoothClass selectedBooth = null;
        private void experiencesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (debounce) { return; } // If experiences list box is being update, ignore events.

            int index = experiencesListBox.SelectedIndex;
            string item = (string) experiencesListBox.SelectedItem;

            if(index >= carnivalOS.Rides.Count) // Since Rides are loaded first, any index value greater than the highest indexed ride is a booth and vice versa.
            {
                selectedRide = null;
                selectedBooth = carnivalOS.Booths[item];

                selectedBooth.displayTicketPrice();
            }
            else
            {
                selectedBooth = null;
                selectedRide = carnivalOS.Rides[item];
                selectedRide.displayTicketPrice();
            }
        }

        private void visiotListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            tickersLeftLabel.Text = $"{carnivalOS.Vistors[visiotListBox.SelectedIndex].Tickets}";
        }

        private void attendExperienceButton_Click(object sender, System.EventArgs e)
        {
            if(visiotListBox.Items.Count == 0 || visiotListBox.SelectedIndex == null || experiencesListBox.Items.Count == 0 || experiencesListBox.SelectedIndex == null)
            {
                MessageBox.Show("Hey... Drink a Rebull... There's no visiots/Experinces.");
                    return;
            }
            int ticketCost = 0;

            if(selectedBooth == null) // getting the the cost of the correct selected experince.
            {
                ticketCost = selectedRide.TicketPrice;
             
            }
            else
            {
                ticketCost = selectedBooth.TicketPrice;
            }

            if(ticketCost > carnivalOS.Vistors[visiotListBox.SelectedIndex].Tickets) // checking if the visiot has enough tickets.
            {
                MessageBox.Show("You Do Not Have Enough Tickets. Womp fucking womp.");
                return;
            }

            //Spending said amount of tickets, update ticket count, etc.
            carnivalOS.Vistors[visiotListBox.SelectedIndex].spendTickets(ticketCost);
            MessageBox.Show($"You had a great time during whateveer at this experince.");
            tickersLeftLabel.Text = $"{carnivalOS.Vistors[visiotListBox.SelectedIndex].Tickets}";
        }
    }
}
