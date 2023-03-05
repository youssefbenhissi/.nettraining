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
    public partial class SignInDatabse : Form
    {
        public static string Databaseid, Databasename, Databaseemail, Databasepassword, Databasecountry;

        DatabaseProject.DBAccess dBAccess = new DatabaseProject.DBAccess();
        DataTable dtUsers = new DataTable();
        public SignInDatabse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = passwordText.Text;
            if (email.Equals(""))
            {
                MessageBox.Show("Please enter email ");
            }else if (password.Equals(""))
            {
                MessageBox.Show("Please enter password ");
            }
            else
            {
                string query = "Select * from Users where Password = '" + password + "' AND Email = '" + email+"'";
                dBAccess.readDatathroughAdapter(query , dtUsers); 
                if(dtUsers.Rows.Count  == 1)
                {

                    Databaseid = dtUsers.Rows[0]["ID"].ToString();
                    Databasename = dtUsers.Rows[0]["Name"].ToString();
                    Databasepassword = dtUsers.Rows[0]["Password"].ToString();
                    Databaseemail = dtUsers.Rows[0]["Email"].ToString();
                    Databasecountry = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("Congratulations , you are logged in Successfully ");
                    dBAccess.closeConn();
                    this.Hide();
                    HomePageDatabase form = new HomePageDatabase();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpDatabse form = new SignUpDatabse();
            form.Show();
        }
    }
}
