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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            helloWorldLabel.Text = "Hello World Again  Again...";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            helloWorldLabel.Text = "Text has been Cancelled ...";
        }
    }
}
