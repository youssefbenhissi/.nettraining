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
    public partial class SignUp : Form
    {
        public static string firstNameText ="";
        public static string lastNameText = "";
        public static string emailAdressText = "";
        public static bool smsIsChecked;
        public static bool reportsIsChecked;
        public static bool transcationReportsIsChecked; 
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsReportsTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TransactionsReportsTextBox.Checked)
            {
                label2.Show();
            }
            else
            {
                label2.Hide();
            }
        }

        private void SmsNotificationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SmsNotificationCheckBox.Checked)
            {
                label1.Show();
            }
            else
            {
                label1.Hide();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstNameText = FirstNameTextBox.Text;
            lastNameText = LastNameTextBox.Text;
            emailAdressText = EmailAdressTextBox.Text;
            smsIsChecked = SmsNotificationCheckBox.Checked;
            reportsIsChecked = ReportsCheckBox.Checked;
            transcationReportsIsChecked = TransactionsReportsTextBox.Checked;
            Confirmation form = new Confirmation();
            form.Show();
        }
    }
}
