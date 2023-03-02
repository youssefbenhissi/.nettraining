namespace final
{
    partial class RadioBox
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
            this.submitButton = new System.Windows.Forms.Button();
            this.muhaedAliRadioButton = new System.Windows.Forms.RadioButton();
            this.peterParkerRadioButton = new System.Windows.Forms.RadioButton();
            this.RidaPetersonRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RidaPetersonRadioButton);
            this.groupBox1.Controls.Add(this.peterParkerRadioButton);
            this.groupBox1.Controls.Add(this.muhaedAliRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(110, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Developers";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(579, 392);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // muhaedAliRadioButton
            // 
            this.muhaedAliRadioButton.AutoSize = true;
            this.muhaedAliRadioButton.Location = new System.Drawing.Point(93, 73);
            this.muhaedAliRadioButton.Name = "muhaedAliRadioButton";
            this.muhaedAliRadioButton.Size = new System.Drawing.Size(86, 17);
            this.muhaedAliRadioButton.TabIndex = 0;
            this.muhaedAliRadioButton.TabStop = true;
            this.muhaedAliRadioButton.Text = "Muhamed Ali";
            this.muhaedAliRadioButton.UseVisualStyleBackColor = true;
            // 
            // peterParkerRadioButton
            // 
            this.peterParkerRadioButton.AutoSize = true;
            this.peterParkerRadioButton.Location = new System.Drawing.Point(93, 133);
            this.peterParkerRadioButton.Name = "peterParkerRadioButton";
            this.peterParkerRadioButton.Size = new System.Drawing.Size(84, 17);
            this.peterParkerRadioButton.TabIndex = 1;
            this.peterParkerRadioButton.TabStop = true;
            this.peterParkerRadioButton.Text = "Peter Parker";
            this.peterParkerRadioButton.UseVisualStyleBackColor = true;
            // 
            // RidaPetersonRadioButton
            // 
            this.RidaPetersonRadioButton.AutoSize = true;
            this.RidaPetersonRadioButton.Location = new System.Drawing.Point(93, 191);
            this.RidaPetersonRadioButton.Name = "RidaPetersonRadioButton";
            this.RidaPetersonRadioButton.Size = new System.Drawing.Size(92, 17);
            this.RidaPetersonRadioButton.TabIndex = 2;
            this.RidaPetersonRadioButton.TabStop = true;
            this.RidaPetersonRadioButton.Text = "Rida Peterson";
            this.RidaPetersonRadioButton.UseVisualStyleBackColor = true;
            this.RidaPetersonRadioButton.UseWaitCursor = true;
            // 
            // RadioBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "RadioBox";
            this.Text = "RadioBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RidaPetersonRadioButton;
        private System.Windows.Forms.RadioButton peterParkerRadioButton;
        private System.Windows.Forms.RadioButton muhaedAliRadioButton;
        private System.Windows.Forms.Button submitButton;
    }
}