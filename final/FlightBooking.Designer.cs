namespace final
{
    partial class FlightBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.identificationcardRadioBox = new System.Windows.Forms.RadioButton();
            this.PasseportRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.DocumentNoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(215, 36);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(125, 22);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.TextChanged += new System.EventHandler(this.toTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(567, 39);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(125, 22);
            this.fromTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "choose your scroll (Scroll to select range or use shift key)";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(164, 124);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(280, 352);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(567, 356);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Travel Document";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.identificationcardRadioBox);
            this.panel1.Controls.Add(this.PasseportRadioButton);
            this.panel1.Location = new System.Drawing.Point(301, 394);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 39);
            this.panel1.TabIndex = 11;
            // 
            // identificationcardRadioBox
            // 
            this.identificationcardRadioBox.AutoSize = true;
            this.identificationcardRadioBox.Location = new System.Drawing.Point(117, 11);
            this.identificationcardRadioBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.identificationcardRadioBox.Name = "identificationcardRadioBox";
            this.identificationcardRadioBox.Size = new System.Drawing.Size(142, 21);
            this.identificationcardRadioBox.TabIndex = 1;
            this.identificationcardRadioBox.TabStop = true;
            this.identificationcardRadioBox.Text = "Identification Card";
            this.identificationcardRadioBox.UseVisualStyleBackColor = true;
            this.identificationcardRadioBox.CheckedChanged += new System.EventHandler(this.identificationcardRadioBox_CheckedChanged);
            // 
            // PasseportRadioButton
            // 
            this.PasseportRadioButton.AutoSize = true;
            this.PasseportRadioButton.Location = new System.Drawing.Point(11, 10);
            this.PasseportRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasseportRadioButton.Name = "PasseportRadioButton";
            this.PasseportRadioButton.Size = new System.Drawing.Size(93, 21);
            this.PasseportRadioButton.TabIndex = 0;
            this.PasseportRadioButton.TabStop = true;
            this.PasseportRadioButton.Text = "Passeport";
            this.PasseportRadioButton.UseVisualStyleBackColor = true;
            this.PasseportRadioButton.CheckedChanged += new System.EventHandler(this.PasseportRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Document No : ";
            // 
            // DocumentNoTextBox
            // 
            this.DocumentNoTextBox.Location = new System.Drawing.Point(736, 406);
            this.DocumentNoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocumentNoTextBox.Name = "DocumentNoTextBox";
            this.DocumentNoTextBox.Size = new System.Drawing.Size(167, 22);
            this.DocumentNoTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Document Issue Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 475);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Document Expiry Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(800, 479);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Baggage (Provide an estimate )";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 572);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1071, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Book ( without paying )";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.domainUpDown1.Location = new System.Drawing.Point(418, 532);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 22);
            this.domainUpDown1.TabIndex = 21;
            this.domainUpDown1.ValueChanged += new System.EventHandler(this.domainUpDown1_ValueChanged);
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 613);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DocumentNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightBooking";
            this.Text = "FlightBooking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton identificationcardRadioBox;
        private System.Windows.Forms.RadioButton PasseportRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DocumentNoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown domainUpDown1;
    }
}