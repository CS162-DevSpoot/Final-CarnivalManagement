using CS162_Final_CarnivalManagement.Management;
using System.Windows.Forms;

/*
 * CS162 FINAL | SPRING 2024
 * Carnival Management System.
 * 
 * Must Incorporate:
 *  - Dictionaries | Found In "CarnivalClass" (Under The "Management" Folder).
 *  - Classes | Found In "Experiences" Folder & "Management" Folder.
 *  - Inheritance | Found In "RideClass" & "BoothClass" (Under The "Experiences" Folder).
 *  - Polymorphism | Found In ExperienceClass and SubClasses (Under The "Experiences" Folder).
 *  - Interfaces | Found In "Management" Folder, W/ It Being Incpproated Into "CarnivalClass".
 *  
 *  @author Nathaniel A. Rivera
 *  @modified 6/8/2024
 */
namespace CS162_Final_CarnivalManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        CarnivalClass carnivalOS = new CarnivalClass(1.5m);

        private void carnivalManagementButton_Click(object sender, System.EventArgs e)
        {
            Form carnvialManagement = new CarnivalManagementForm(carnivalOS);
            carnvialManagement.Show();
        }

        private void visitorDemoButton_Click(object sender, System.EventArgs e)
        {
            Form visitorDemo = new VisitorDemoForm(carnivalOS);
            visitorDemo.Show();
        }
    }
}
