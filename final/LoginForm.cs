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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

            private void loginButton_Click(object sender, EventArgs e)
        {
            if(UserIdTextBox.Text == "i25" && PasswordTextBox.Text == "12345")
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            UserIdTextBox.Text = "";
            PasswordTextBox.Text = "";
            UserIdTextBox.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
          
        }

        private void LoginForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                resetButton.PerformClick();
            }
        }
    }
}
