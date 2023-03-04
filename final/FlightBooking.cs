using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class FlightBooking : Form
    {
        public static string fullName;
        public static string departureCity;
        public static string destinationCity;
        public static string tripDates;
        public static string documentationNo;
        public static string documentationExpiryDate;
        public static string weight;
        public static string documentLabel;
        public static string documentationIdLabel;
        public FlightBooking()
        {
            InitializeComponent();
        }

        private void FlightBooking_Load(object sender, EventArgs e)
        {
        }

        private void toTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            destinationCity = toTextBox.Text;
            departureCity = fromTextBox.Text;
            fullName = firstNameTextBox.Text + " " + textBox1.Text;
            tripDates = monthCalendar1.SelectionStart.ToShortDateString() + " to " + monthCalendar1.SelectionEnd.ToShortDateString();
            documentationNo = DocumentNoTextBox.Text;
            documentationExpiryDate = dateTimePicker2.Value.ToShortDateString();
            weight = domainUpDown1.Value.ToString();
            if (PasseportRadioButton.Checked)
            {
                documentLabel = "Passeport No : ";
                documentationIdLabel = "Passeport Expiry Date : ";
            }else if (identificationcardRadioBox.Checked)
            {
                documentLabel = "Identification Card No :";
                documentationIdLabel = "Identification Expiry Date : ";
            }
            this.Hide();
            Booking_Summary form = new Booking_Summary();
            form.Show();
        }

        private void PasseportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PasseportRadioButton.Checked)
            {
                label7.Text = "Passeport No: ";
                label8.Text = "Passeport Issue Date: ";
                label9.Text = "Passeport Expiry Date: ";
            }
        }

        private void identificationcardRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (identificationcardRadioBox.Checked)
            {
                label7.Text = "ID Card No: ";
                label8.Text = "ID Card Issue Date: ";
                label9.Text = "ID Card Expiry Date: ";
            }
        }

        private void domainUpDown1_ValueChanged(object sender, EventArgs e)
        {
            domainUpDown1.Increment += 5;
        }
    }
}
