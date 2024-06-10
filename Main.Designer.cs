namespace CS162_Final_CarnivalManagement
{
    partial class Main
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
            this.carnivalManagementButton = new System.Windows.Forms.Button();
            this.visitorDemoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carnivalManagementButton
            // 
            this.carnivalManagementButton.Location = new System.Drawing.Point(62, 133);
            this.carnivalManagementButton.Name = "carnivalManagementButton";
            this.carnivalManagementButton.Size = new System.Drawing.Size(151, 23);
            this.carnivalManagementButton.TabIndex = 0;
            this.carnivalManagementButton.Text = "Carnival Management";
            this.carnivalManagementButton.UseVisualStyleBackColor = true;
            this.carnivalManagementButton.Click += new System.EventHandler(this.carnivalManagementButton_Click);
            // 
            // visitorDemoButton
            // 
            this.visitorDemoButton.Location = new System.Drawing.Point(229, 132);
            this.visitorDemoButton.Name = "visitorDemoButton";
            this.visitorDemoButton.Size = new System.Drawing.Size(124, 23);
            this.visitorDemoButton.TabIndex = 1;
            this.visitorDemoButton.Text = "Visitor Demo";
            this.visitorDemoButton.UseVisualStyleBackColor = true;
            this.visitorDemoButton.Click += new System.EventHandler(this.visitorDemoButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = " CS 162\r\nCarnival Management\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visitorDemoButton);
            this.Controls.Add(this.carnivalManagementButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carnivalManagementButton;
        private System.Windows.Forms.Button visitorDemoButton;
        private System.Windows.Forms.Label label1;
    }
}

