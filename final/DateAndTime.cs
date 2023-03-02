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
    public partial class DateAndTime : Form
    {
        public DateAndTime()
        {
            InitializeComponent();
        }

        private void DateType1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateType1.Text = dateTimePicker1.Value.ToString();
            DataType2.Text = dateTimePicker1.Value.ToShortDateString();
            DateType3.Text = dateTimePicker1.Value.ToLongDateString();
            TimeType1.Text = dateTimePicker1.Value.ToShortTimeString();
            TimeType2.Text = dateTimePicker1.Value.ToLongTimeString();
        }
    }
}
