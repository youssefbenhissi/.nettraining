namespace final
{
    partial class SignUp
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailAdressLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAdressTextBox = new System.Windows.Forms.TextBox();
            this.Services = new System.Windows.Forms.GroupBox();
            this.SmsNotificationCheckBox = new System.Windows.Forms.CheckBox();
            this.ReportsCheckBox = new System.Windows.Forms.CheckBox();
            this.TransactionsReportsTextBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.Services.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(134, 71);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(66, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name : ";
            this.FirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(134, 119);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(67, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name : ";
            // 
            // EmailAdressLabel
            // 
            this.EmailAdressLabel.AutoSize = true;
            this.EmailAdressLabel.Location = new System.Drawing.Point(134, 173);
            this.EmailAdressLabel.Name = "EmailAdressLabel";
            this.EmailAdressLabel.Size = new System.Drawing.Size(76, 13);
            this.EmailAdressLabel.TabIndex = 2;
            this.EmailAdressLabel.Text = "Email Adress : ";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(225, 71);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(376, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(225, 119);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(376, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // EmailAdressTextBox
            // 
            this.EmailAdressTextBox.Location = new System.Drawing.Point(225, 170);
            this.EmailAdressTextBox.Name = "EmailAdressTextBox";
            this.EmailAdressTextBox.Size = new System.Drawing.Size(376, 20);
            this.EmailAdressTextBox.TabIndex = 5;
            // 
            // Services
            // 
            this.Services.Controls.Add(this.label2);
            this.Services.Controls.Add(this.label1);
            this.Services.Controls.Add(this.TransactionsReportsTextBox);
            this.Services.Controls.Add(this.ReportsCheckBox);
            this.Services.Controls.Add(this.SmsNotificationCheckBox);
            this.Services.Location = new System.Drawing.Point(84, 264);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(576, 125);
            this.Services.TabIndex = 6;
            this.Services.TabStop = false;
            this.Services.Text = "groupBox1";
            // 
            // SmsNotificationCheckBox
            // 
            this.SmsNotificationCheckBox.AutoSize = true;
            this.SmsNotificationCheckBox.Location = new System.Drawing.Point(77, 32);
            this.SmsNotificationCheckBox.Name = "SmsNotificationCheckBox";
            this.SmsNotificationCheckBox.Size = new System.Drawing.Size(110, 17);
            this.SmsNotificationCheckBox.TabIndex = 0;
            this.SmsNotificationCheckBox.Text = "SMS Notifications";
            this.SmsNotificationCheckBox.UseVisualStyleBackColor = true;
            this.SmsNotificationCheckBox.CheckedChanged += new System.EventHandler(this.SmsNotificationCheckBox_CheckedChanged);
            // 
            // ReportsCheckBox
            // 
            this.ReportsCheckBox.AutoSize = true;
            this.ReportsCheckBox.Location = new System.Drawing.Point(77, 64);
            this.ReportsCheckBox.Name = "ReportsCheckBox";
            this.ReportsCheckBox.Size = new System.Drawing.Size(63, 17);
            this.ReportsCheckBox.TabIndex = 1;
            this.ReportsCheckBox.Text = "Reports";
            this.ReportsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransactionsReportsTextBox
            // 
            this.TransactionsReportsTextBox.AutoSize = true;
            this.TransactionsReportsTextBox.Location = new System.Drawing.Point(77, 102);
            this.TransactionsReportsTextBox.Name = "TransactionsReportsTextBox";
            this.TransactionsReportsTextBox.Size = new System.Drawing.Size(122, 17);
            this.TransactionsReportsTextBox.TabIndex = 2;
            this.TransactionsReportsTextBox.Text = "Transaction Reports";
            this.TransactionsReportsTextBox.UseVisualStyleBackColor = true;
            this.TransactionsReportsTextBox.CheckedChanged += new System.EventHandler(this.TransactionsReportsTextBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Services charges may apply for SMS";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Services charges may apply for Transaction Reports";
            this.label2.Visible = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(526, 415);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.EmailAdressTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmailAdressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailAdressLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailAdressTextBox;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.CheckBox TransactionsReportsTextBox;
        private System.Windows.Forms.CheckBox ReportsCheckBox;
        private System.Windows.Forms.CheckBox SmsNotificationCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
    }
}