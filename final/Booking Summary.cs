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
    public partial class Booking_Summary : Form
    {
        public Booking_Summary()
        {
            InitializeComponent();
            fullNameLabel.Text = FlightBooking.fullName;
            departueCityLabel.Text = FlightBooking.departureCity;
            DestinationCityLabel.Text = FlightBooking.destinationCity;
            tripDatesLabel.Text = FlightBooking.tripDates;
            idLabel.Text = FlightBooking.documentationNo;
            expiryDateLabel.Text = FlightBooking.documentationExpiryDate;
            weightLabel.Text = FlightBooking.weight;
            label6.Text = FlightBooking.documentLabel;
            label7.Text = FlightBooking.documentationIdLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
    }
}
