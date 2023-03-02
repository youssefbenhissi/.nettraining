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
    public partial class RadioBox : Form
    {
        public RadioBox()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (muhaedAliRadioButton.Checked)
            {
                MessageBox.Show(muhaedAliRadioButton.Text);
            }else if (peterParkerRadioButton.Checked)
            {
                MessageBox.Show(peterParkerRadioButton.Text);

            }
            else if (RidaPetersonRadioButton.Checked)
            {
                MessageBox.Show(RidaPetersonRadioButton.Text);

            }
        }
    }
}
