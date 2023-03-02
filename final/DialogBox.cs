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
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
           DialogResult dr=  MessageBox.Show("1: To Purchase, Press = YES. \n 2: For Trial Version, Press = 2 \n 3: Cancel Order ", "Purchase Software", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                label2.Text = "Congratulations, you have purchased the complete software for unlimited";
            }
            else if ( dr == DialogResult.No)
            {
                label2.Text = "you can use this software for FREE for 30 days";
            }
            else if (dr == DialogResult.Cancel)
            {
                label1.Text = "You cancelled the order";
            }
        }
    }
}
