using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbLow.Checked)
            {
                GameForm.DIFFICULTY = Difficulty.Low;
            }
            else if (rbMid.Checked)
            {
                GameForm.DIFFICULTY = Difficulty.Middle;
            }
            else if (rbMid.Checked)
            {
                GameForm.DIFFICULTY = Difficulty.Low;
            }
            this.Close();
        }
    }
}
