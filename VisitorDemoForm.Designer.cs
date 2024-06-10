namespace CS162_Final_CarnivalManagement
{
    partial class VisitorDemoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visiotListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attendExperienceButton = new System.Windows.Forms.Button();
            this.experiencesListBox = new System.Windows.Forms.ListBox();
            this.tickersLeftLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visiotListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitors";
            // 
            // visiotListBox
            // 
            this.visiotListBox.FormattingEnabled = true;
            this.visiotListBox.Location = new System.Drawing.Point(6, 19);
            this.visiotListBox.Name = "visiotListBox";
            this.visiotListBox.Size = new System.Drawing.Size(188, 160);
            this.visiotListBox.TabIndex = 0;
            this.visiotListBox.SelectedIndexChanged += new System.EventHandler(this.visiotListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tickersLeftLabel);
            this.groupBox2.Location = new System.Drawing.Point(516, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tickets Remaining";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.experiencesListBox);
            this.groupBox3.Controls.Add(this.attendExperienceButton);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Experience";
            // 
            // attendExperienceButton
            // 
            this.attendExperienceButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.attendExperienceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.attendExperienceButton.Location = new System.Drawing.Point(6, 154);
            this.attendExperienceButton.Name = "attendExperienceButton";
            this.attendExperienceButton.Size = new System.Drawing.Size(280, 23);
            this.attendExperienceButton.TabIndex = 0;
            this.attendExperienceButton.Text = "Attend Experience";
            this.attendExperienceButton.UseVisualStyleBackColor = false;
            this.attendExperienceButton.Click += new System.EventHandler(this.attendExperienceButton_Click);
            // 
            // experiencesListBox
            // 
            this.experiencesListBox.FormattingEnabled = true;
            this.experiencesListBox.Location = new System.Drawing.Point(6, 19);
            this.experiencesListBox.Name = "experiencesListBox";
            this.experiencesListBox.Size = new System.Drawing.Size(280, 121);
            this.experiencesListBox.TabIndex = 1;
            this.experiencesListBox.SelectedIndexChanged += new System.EventHandler(this.experiencesListBox_SelectedIndexChanged);
            // 
            // tickersLeftLabel
            // 
            this.tickersLeftLabel.Location = new System.Drawing.Point(6, 19);
            this.tickersLeftLabel.Name = "tickersLeftLabel";
            this.tickersLeftLabel.Size = new System.Drawing.Size(188, 28);
            this.tickersLeftLabel.TabIndex = 0;
            this.tickersLeftLabel.Text = "N / A";
            this.tickersLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitorDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 209);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorDemoForm";
            this.Text = "VisitorDemoForm";
            this.Load += new System.EventHandler(this.VisitorDemoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox visiotListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label tickersLeftLabel;
        private System.Windows.Forms.ListBox experiencesListBox;
        private System.Windows.Forms.Button attendExperienceButton;
    }
}