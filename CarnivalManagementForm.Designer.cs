namespace CS162_Final_CarnivalManagement
{
    partial class CarnivalManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.grossLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.visitorsLabel = new System.Windows.Forms.Label();
            this.experiencesListBox = new System.Windows.Forms.ListBox();
            this.visitorListBox = new System.Windows.Forms.ListBox();
            this.addExperienceButton = new System.Windows.Forms.Button();
            this.addVistorLabel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorName_TextBox = new System.Windows.Forms.TextBox();
            this.visitorTickets_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.experienceCapcity_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.experienceCost_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.experienceName_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rideRadioButton = new System.Windows.Forms.RadioButton();
            this.boothRadioButton = new System.Windows.Forms.RadioButton();
            this.bothPrize_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rideHeight_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(12, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 112);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visitorTickets_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.visitorName_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addVistorLabel);
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Visitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.visitorListBox);
            this.groupBox2.Location = new System.Drawing.Point(507, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 351);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitors";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bothPrize_TextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rideHeight_TextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.experienceCapcity_TextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.experienceCost_TextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.experienceName_TextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addExperienceButton);
            this.groupBox3.Location = new System.Drawing.Point(260, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 351);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Experience";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.experiencesListBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 351);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Experiences";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.soldLabel);
            this.groupBox5.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox5.Location = new System.Drawing.Point(385, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 95);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Tickets Sold";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.grossLabel);
            this.groupBox6.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox6.Location = new System.Drawing.Point(179, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 95);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gross";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.visitorsLabel);
            this.groupBox7.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox7.Location = new System.Drawing.Point(591, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 95);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Total Vistors";
            // 
            // grossLabel
            // 
            this.grossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.ForeColor = System.Drawing.Color.Ivory;
            this.grossLabel.Location = new System.Drawing.Point(6, 37);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(188, 23);
            this.grossLabel.TabIndex = 0;
            this.grossLabel.Text = "N / A";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soldLabel
            // 
            this.soldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldLabel.ForeColor = System.Drawing.Color.Ivory;
            this.soldLabel.Location = new System.Drawing.Point(6, 36);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(188, 23);
            this.soldLabel.TabIndex = 1;
            this.soldLabel.Text = "N / A";
            this.soldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitorsLabel
            // 
            this.visitorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorsLabel.ForeColor = System.Drawing.Color.Ivory;
            this.visitorsLabel.Location = new System.Drawing.Point(6, 36);
            this.visitorsLabel.Name = "visitorsLabel";
            this.visitorsLabel.Size = new System.Drawing.Size(188, 23);
            this.visitorsLabel.TabIndex = 1;
            this.visitorsLabel.Text = "N / A";
            this.visitorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // experiencesListBox
            // 
            this.experiencesListBox.FormattingEnabled = true;
            this.experiencesListBox.Location = new System.Drawing.Point(6, 19);
            this.experiencesListBox.Name = "experiencesListBox";
            this.experiencesListBox.Size = new System.Drawing.Size(229, 316);
            this.experiencesListBox.TabIndex = 0;
            // 
            // visitorListBox
            // 
            this.visitorListBox.FormattingEnabled = true;
            this.visitorListBox.Location = new System.Drawing.Point(6, 17);
            this.visitorListBox.Name = "visitorListBox";
            this.visitorListBox.Size = new System.Drawing.Size(229, 316);
            this.visitorListBox.TabIndex = 1;
            // 
            // addExperienceButton
            // 
            this.addExperienceButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addExperienceButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.addExperienceButton.Location = new System.Drawing.Point(6, 322);
            this.addExperienceButton.Name = "addExperienceButton";
            this.addExperienceButton.Size = new System.Drawing.Size(230, 23);
            this.addExperienceButton.TabIndex = 0;
            this.addExperienceButton.Text = "Add";
            this.addExperienceButton.UseVisualStyleBackColor = false;
            this.addExperienceButton.Click += new System.EventHandler(this.addExperienceButton_Click);
            // 
            // addVistorLabel
            // 
            this.addVistorLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.addVistorLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.addVistorLabel.Location = new System.Drawing.Point(7, 322);
            this.addVistorLabel.Name = "addVistorLabel";
            this.addVistorLabel.Size = new System.Drawing.Size(230, 23);
            this.addVistorLabel.TabIndex = 1;
            this.addVistorLabel.Text = "Add";
            this.addVistorLabel.UseVisualStyleBackColor = false;
            this.addVistorLabel.Click += new System.EventHandler(this.addVistorLabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visitor Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // visitorName_TextBox
            // 
            this.visitorName_TextBox.Location = new System.Drawing.Point(5, 43);
            this.visitorName_TextBox.Name = "visitorName_TextBox";
            this.visitorName_TextBox.Size = new System.Drawing.Size(235, 20);
            this.visitorName_TextBox.TabIndex = 3;
            // 
            // visitorTickets_TextBox
            // 
            this.visitorTickets_TextBox.Location = new System.Drawing.Point(5, 92);
            this.visitorTickets_TextBox.Name = "visitorTickets_TextBox";
            this.visitorTickets_TextBox.Size = new System.Drawing.Size(235, 20);
            this.visitorTickets_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount of Tickets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // experienceCapcity_TextBox
            // 
            this.experienceCapcity_TextBox.Location = new System.Drawing.Point(4, 143);
            this.experienceCapcity_TextBox.Name = "experienceCapcity_TextBox";
            this.experienceCapcity_TextBox.Size = new System.Drawing.Size(235, 20);
            this.experienceCapcity_TextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Experience Capacity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // experienceCost_TextBox
            // 
            this.experienceCost_TextBox.Location = new System.Drawing.Point(4, 94);
            this.experienceCost_TextBox.Name = "experienceCost_TextBox";
            this.experienceCost_TextBox.Size = new System.Drawing.Size(235, 20);
            this.experienceCost_TextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ticket Cost";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // experienceName_TextBox
            // 
            this.experienceName_TextBox.Location = new System.Drawing.Point(4, 45);
            this.experienceName_TextBox.Name = "experienceName_TextBox";
            this.experienceName_TextBox.Size = new System.Drawing.Size(235, 20);
            this.experienceName_TextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Experience Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.boothRadioButton);
            this.groupBox9.Controls.Add(this.rideRadioButton);
            this.groupBox9.Location = new System.Drawing.Point(6, 169);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(233, 48);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Type";
            // 
            // rideRadioButton
            // 
            this.rideRadioButton.AutoSize = true;
            this.rideRadioButton.Checked = true;
            this.rideRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rideRadioButton.Name = "rideRadioButton";
            this.rideRadioButton.Size = new System.Drawing.Size(47, 17);
            this.rideRadioButton.TabIndex = 0;
            this.rideRadioButton.TabStop = true;
            this.rideRadioButton.Text = "Ride";
            this.rideRadioButton.UseVisualStyleBackColor = true;
            this.rideRadioButton.CheckedChanged += new System.EventHandler(this.rideRadioButton_CheckedChanged);
            // 
            // boothRadioButton
            // 
            this.boothRadioButton.AutoSize = true;
            this.boothRadioButton.Location = new System.Drawing.Point(59, 19);
            this.boothRadioButton.Name = "boothRadioButton";
            this.boothRadioButton.Size = new System.Drawing.Size(53, 17);
            this.boothRadioButton.TabIndex = 1;
            this.boothRadioButton.Text = "Booth";
            this.boothRadioButton.UseVisualStyleBackColor = true;
            this.boothRadioButton.CheckedChanged += new System.EventHandler(this.boothRadioButton_CheckedChanged);
            // 
            // bothPrize_TextBox
            // 
            this.bothPrize_TextBox.Enabled = false;
            this.bothPrize_TextBox.Location = new System.Drawing.Point(4, 297);
            this.bothPrize_TextBox.Name = "bothPrize_TextBox";
            this.bothPrize_TextBox.Size = new System.Drawing.Size(235, 20);
            this.bothPrize_TextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Booth Prize";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rideHeight_TextBox
            // 
            this.rideHeight_TextBox.Location = new System.Drawing.Point(4, 248);
            this.rideHeight_TextBox.Name = "rideHeight_TextBox";
            this.rideHeight_TextBox.Size = new System.Drawing.Size(235, 20);
            this.rideHeight_TextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ride Height Requirement";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(901, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // CarnivalManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 493);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CarnivalManagementForm";
            this.Text = "CarnivalManagementForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label visitorsLabel;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addVistorLabel;
        private System.Windows.Forms.ListBox visitorListBox;
        private System.Windows.Forms.Button addExperienceButton;
        private System.Windows.Forms.ListBox experiencesListBox;
        private System.Windows.Forms.TextBox visitorTickets_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visitorName_TextBox;
        private System.Windows.Forms.TextBox experienceCapcity_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox experienceCost_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox experienceName_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bothPrize_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rideHeight_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton boothRadioButton;
        private System.Windows.Forms.RadioButton rideRadioButton;
        private System.Windows.Forms.Button refreshButton;
    }
}