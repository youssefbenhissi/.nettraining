namespace final
{
    partial class DateAndTime
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DateType1 = new System.Windows.Forms.Label();
            this.DataType2 = new System.Windows.Forms.Label();
            this.DateType3 = new System.Windows.Forms.Label();
            this.TimeType1 = new System.Windows.Forms.Label();
            this.TimeType2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Type 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Type 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Type 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time Type 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time Type 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateType1
            // 
            this.DateType1.AutoSize = true;
            this.DateType1.Location = new System.Drawing.Point(365, 101);
            this.DateType1.Name = "DateType1";
            this.DateType1.Size = new System.Drawing.Size(35, 13);
            this.DateType1.TabIndex = 7;
            this.DateType1.Text = "label6";
            this.DateType1.Click += new System.EventHandler(this.DateType1_Click);
            // 
            // DataType2
            // 
            this.DataType2.AutoSize = true;
            this.DataType2.Location = new System.Drawing.Point(365, 138);
            this.DataType2.Name = "DataType2";
            this.DataType2.Size = new System.Drawing.Size(35, 13);
            this.DataType2.TabIndex = 8;
            this.DataType2.Text = "label7";
            // 
            // DateType3
            // 
            this.DateType3.AutoSize = true;
            this.DateType3.Location = new System.Drawing.Point(365, 180);
            this.DateType3.Name = "DateType3";
            this.DateType3.Size = new System.Drawing.Size(35, 13);
            this.DateType3.TabIndex = 9;
            this.DateType3.Text = "label8";
            // 
            // TimeType1
            // 
            this.TimeType1.AutoSize = true;
            this.TimeType1.Location = new System.Drawing.Point(365, 219);
            this.TimeType1.Name = "TimeType1";
            this.TimeType1.Size = new System.Drawing.Size(35, 13);
            this.TimeType1.TabIndex = 10;
            this.TimeType1.Text = "label9";
            // 
            // TimeType2
            // 
            this.TimeType2.AutoSize = true;
            this.TimeType2.Location = new System.Drawing.Point(365, 258);
            this.TimeType2.Name = "TimeType2";
            this.TimeType2.Size = new System.Drawing.Size(41, 13);
            this.TimeType2.TabIndex = 11;
            this.TimeType2.Text = "label10";
            // 
            // DateAndTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeType2);
            this.Controls.Add(this.TimeType1);
            this.Controls.Add(this.DateType3);
            this.Controls.Add(this.DataType2);
            this.Controls.Add(this.DateType1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateAndTime";
            this.Text = "DateAndTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateType1;
        private System.Windows.Forms.Label DataType2;
        private System.Windows.Forms.Label DateType3;
        private System.Windows.Forms.Label TimeType1;
        private System.Windows.Forms.Label TimeType2;
    }
}