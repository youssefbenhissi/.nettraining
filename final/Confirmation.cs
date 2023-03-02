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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
            FirstNameLabel.Text  = SignUp.firstNameText;
            LastNameLabel.Text = SignUp.lastNameText;
            EmailLabel.Text = SignUp.emailAdressText;
            if (SignUp.smsIsChecked)
            {
                SmsLabel.Text = "✔";
            }
            else
            {
                SmsLabel.Text = "✗";

            }
            if (SignUp.reportsIsChecked)
            {
                ReportsLabel.Text = "✔";
            }
            else
            {
                ReportsLabel.Text = "✗";
            }
            if (SignUp.transcationReportsIsChecked)
            {
                TransactionReportsLabel.Text = "✔";
            }
            else
            {
                TransactionReportsLabel.Text = "✗";

            }
        }
    }
}
