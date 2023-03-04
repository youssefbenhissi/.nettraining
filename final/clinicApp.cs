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
    public partial class clinicApp : Form
    {
        DataTable clinicDataTable = new DataTable();
        DataTable doctorsDataTable = new DataTable();
        DataTable doctorsToBeShown= new DataTable();
        public clinicApp()
        {
            InitializeComponent();
          
        }

        private void fill_doctors()
        {
            doctorsDataTable.Columns.Add("DoctorId",typeof(int));
            doctorsDataTable.Columns.Add("DoctorName");
            doctorsDataTable.Columns.Add("DoctorSpeciality");
            doctorsDataTable.Columns.Add("DoctorContact");
            doctorsDataTable.Rows.Add(1, "ali", "Heart surgeon", "01645");
            doctorsDataTable.Rows.Add(1, "youssef", "doctor 2", "01645");
            doctorsDataTable.Rows.Add(2, "ali", "doctor 3", "01354645");
            doctorsDataTable.Rows.Add(2, "mustapha", "doctor 4", "016431355");
            doctorsDataTable.Rows.Add(3, "waa", "Heart surgeon", "01645");
            doctorsDataTable.Rows.Add(3, "kkk", "doctor 2", "01645");
            doctorsDataTable.Rows.Add(4, "sss", "Heart surgeon", "01645");
            doctorsDataTable.Rows.Add(4, "vvv", "doctor 2", "01645");
        }

        private void fill_clinicDataTable()
        {
            clinicDataTable.Columns.Add("ClinicId", typeof(int));
            clinicDataTable.Columns.Add("ClinicName");
            clinicDataTable.Columns.Add("ClinicAdress");
            clinicDataTable.Columns.Add("ContactNo");
            clinicDataTable.Columns.Add("ClinicRating");
            clinicDataTable.Rows.Add(1, "Dentist Pro Clinic", "Palo Alto, California", "090016860111", "7,1/10");
            clinicDataTable.Rows.Add(2, "Muhamed Ali's Center,Free for all", "lac 1", "1234", "10/10");
            clinicDataTable.Rows.Add(3, "IPO Clinic Pro", "zone urbaine", "56789", "9/10");
            clinicDataTable.Rows.Add(4, "Healthy Heart Service", "jardin de carthage", "975310", "6/10");
        }

        private void clinicApp_Load(object sender, EventArgs e)
        {
            fill_clinicDataTable();
            fill_doctors();


            comboBox1.DataSource = clinicDataTable;
            comboBox1.DisplayMember = "ClinicName";
            comboBox2.DisplayMember = "DoctorName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClinicAdress.Text = clinicDataTable.Rows[comboBox1.SelectedIndex]["ClinicAdress"].ToString();
            lblClinicName.Text = clinicDataTable.Rows[comboBox1.SelectedIndex]["ClinicName"].ToString();
            lblCLinicRate.Text = clinicDataTable.Rows[comboBox1.SelectedIndex]["ClinicRating"].ToString();
            label6.Text = clinicDataTable.Rows[comboBox1.SelectedIndex]["ContactNo"].ToString();

            doctorsToBeShown = doctorsDataTable.Select("DoctorId = " + clinicDataTable.Rows[comboBox1.SelectedIndex]["ClinicId"].ToString()).CopyToDataTable();
            comboBox2.DataSource = doctorsToBeShown;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = doctorsToBeShown.Rows[comboBox2.SelectedIndex]["DoctorName"].ToString();
            label4.Text = doctorsToBeShown.Rows[comboBox2.SelectedIndex]["DoctorSpeciality"].ToString();
            label3.Text = doctorsToBeShown.Rows[comboBox2.SelectedIndex]["DoctorContact"].ToString();
        }
    }
}
