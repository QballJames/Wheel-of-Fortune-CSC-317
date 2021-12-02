using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_of_Fortune_CSC_317
{
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            Player1NameTxt.Enabled = true;
            ReadyButton.Enabled = true;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Player1NameTxt.Enabled = true;
            Player2NameTxt.Enabled = true;
            ReadyButton.Enabled = true;
        }

        private void three_Click(object sender, EventArgs e)
        {
            Player1NameTxt.Enabled = true;
            Player2NameTxt.Enabled = true;
            Player3NameTxt.Enabled = true;
            ReadyButton.Enabled = true;
        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
