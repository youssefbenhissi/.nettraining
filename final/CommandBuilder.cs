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
    public partial class CommandBuilder : Form
    {
        DatabaseProject.DBAccess dBAccess = new DatabaseProject.DBAccess();
        DataTable dtUsers = new DataTable();
        public CommandBuilder()
        {
            InitializeComponent();
        }

        private void CommandBuilder_Load(object sender, EventArgs e)
        {

            string query = "Select * from Users";
            dBAccess.readDatathroughAdapter(query, dtUsers);
            dataGridView1.DataSource = dtUsers;
            dBAccess.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users";
            int changes = dBAccess.executeDataAdapter( dtUsers, query);

        }
    }
}
