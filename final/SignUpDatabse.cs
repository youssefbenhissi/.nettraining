using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class SignUpDatabse : Form
    {
        DBAccess dBAccess = new DBAccess();
        public SignUpDatabse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string country = txtCountry.Text;
            if (name.Equals(""))
            {
                MessageBox.Show("Please enter your name ");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Please enter your Email ");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter your password ");
            }
            else if (country.Equals(""))
            {
                MessageBox.Show("Please enter your country ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@name,@email,@password,@country) ");
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@country", country);
                int row = dBAccess.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Account Create Successfully");
                    this.Hide();
                    SignInDatabse form = new SignInDatabse();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Error occured. Try again ...");

                }
            }
        }
    }
}
