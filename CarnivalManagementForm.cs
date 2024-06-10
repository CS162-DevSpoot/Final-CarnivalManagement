using CS162_Final_CarnivalManagement.Experiences;
using CS162_Final_CarnivalManagement.Management;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CS162_Final_CarnivalManagement
{
    public partial class CarnivalManagementForm : Form
    {
        public CarnivalManagementForm(CarnivalClass carnival)
        {
            carnivalOS = carnival;
            InitializeComponent();
        }

        CarnivalClass carnivalOS = null;

        private void updateStats() // method to update stats.
        {
            decimal grossAmount = carnivalOS.TicketCost * (decimal)carnivalOS.totalSoldTickets;

            grossLabel.Text = $"{grossAmount:c}";
            soldLabel.Text = $"{carnivalOS.totalSoldTickets}";
            visitorsLabel.Text = $"{carnivalOS.Vistors.Count}";
        }

        private void addVistorLabel_Click(object sender, System.EventArgs e) // method for adding a new visitor.
        {
            try
            {
                VisitorClass newVisitor = new VisitorClass();

                string vName = visitorName_TextBox.Text;
                int vTickets = int.Parse(visitorTickets_TextBox.Text);

                newVisitor.Name = vName;
                newVisitor.Tickets = vTickets;
                newVisitor.ID = carnivalOS.Vistors.Count;

                carnivalOS.Vistors.Add(newVisitor.ID, newVisitor);
                carnivalOS.saleTickets(vTickets);

                visitorListBox.Items.Add(vName);
                updateStats();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e) // method for refreshing stats.
        {
            updateStats();
        }

        private void rideRadioButton_CheckedChanged(object sender, EventArgs e) // method that enables & disables textboxes based on the type of experience.
        {
            bothPrize_TextBox.Enabled = false;
            rideHeight_TextBox.Enabled = true;
        }

        private void boothRadioButton_CheckedChanged(object sender, EventArgs e) // method that enables & disables textboxes based on the type of experience.
        {
            bothPrize_TextBox.Enabled = true;
            rideHeight_TextBox.Enabled = false;
        }

        private void addExperienceButton_Click(object sender, EventArgs e) // method for adding a new experince.
        {
            try
            {
                string eName = experienceName_TextBox.Text;
                int eCost = int.Parse(experienceCost_TextBox.Text);
                int eCapacity = int.Parse(experienceCapcity_TextBox.Text);
                string eHight = rideHeight_TextBox.Text;
                string ePrize = bothPrize_TextBox.Text;

                if (rideRadioButton.Checked) // Checking which type of experince it is.
                {
                    RideClass newRide = new RideClass()
                    {
                        Name = eName,
                        Capcitity = eCapacity,
                        HightRequirement = eHight,
                        TicketPrice = eCost
                    };

                    carnivalOS.Rides.Add(eName, newRide);
                }
                else
                {
                    BoothClass newBooth = new BoothClass()
                    {
                        Name = eName,
                        Capcitity = eCapacity,
                        Prize = ePrize,
                        TicketPrice = eCost
                    };

                    carnivalOS.Booths.Add(eName, newBooth);
                }
                    updateExperiences(); // updating experinces.

            }catch(Exception err)
            {
                MessageBox.Show(err.Message); //catching errors.
            }
        }

        private void updateExperiences() // updating experinces, loading rides first than booths.
        {
            experiencesListBox.Items.Clear();
            foreach (var ride in carnivalOS.Rides)
            {
                experiencesListBox.Items.Add(ride.Value.Name);
            }

            foreach (var booth in carnivalOS.Booths)
            {
                experiencesListBox.Items.Add(booth.Value.Name);
            }
        }
    }
}
