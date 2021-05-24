using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string Plyr1 = "X";
        string Plyr2 = "0";
        byte Trn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BrdButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Trn % 2 == 0)
            {
                Trn++;
                button.Text = Plyr1;
                this.TimerBar.Value = 0;
            }
            else
            {
                Trn++;
                button.Text = Plyr2;
                this.TimerBar.Value = 0;
            }
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            if (TimerBar.Value == 100)
            {
                Trn++;
            }
            else
            {
                this.TimerBar.Value += 1;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimeTimer.Enabled = true;
        }
    }
}
