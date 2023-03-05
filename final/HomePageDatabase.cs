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
    public partial class HomePageDatabase : Form
    {
        DatabaseProject.DBAccess dBAccess = new DatabaseProject.DBAccess();

        public HomePageDatabase()
        {
            InitializeComponent();
        }

        private void HomePageDatabase_Load(object sender, EventArgs e)
        {
            label6.Text = "Welcome " + SignInDatabse.Databasename;
            txtName.Text  = SignInDatabse.Databasename;
            txtEmail.Text = SignInDatabse.Databaseemail;
            txtPassword.Text = SignInDatabse.Databasepassword;
            txtCountry.Text = SignInDatabse.Databasecountry;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string email = txtName.Text;
            string password = txtPassword.Text;
            string country = txtCountry.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("please write your name ");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("please write your email");

            }
            else if (password.Equals(""))
            {
                MessageBox.Show("please write your password ");

            }
            else if (country.Equals(""))
            {
                MessageBox.Show("please write your country ");

            }
            else
            {
                string query = "Update Users SET Name = '" + @username + "' , Email = '" + @email + "', Password = '" + @password + "' , Country = '" + @country + "' WHERE ID = '"+SignInDatabse.Databaseid + "'";

                SqlCommand insertCommand = new SqlCommand(query);

                insertCommand.Parameters.AddWithValue("@name", username);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@country", country);

                int row = dBAccess.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Updated Successfuly");
                    this.Hide();

                    SignInDatabse form = new SignInDatabse();
                    form.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult dr =  MessageBox.Show("Are you sure you want to delete this account", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                string query = "Delete from Users where ID = '" + SignInDatabse.Databaseid + "'" ;
                SqlCommand insertCommand = new SqlCommand(query);

                int row = dBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Deleted Successfuly");
                    this.Hide();

                    SignInDatabse form = new SignInDatabse();
                    form.Show();
                }
            }
        }
    }
}
