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
        string Plyr2 = "O";
        byte Trn = 0;

        public Form1()
        {
            InitializeComponent();
            //this.TimerBar.Maximum = 5;
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
            button.Enabled = false;
            Winner();
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            if (TimerBar.Value == 100)
            {
                Trn++;
                TimerBar.Value = 0;
            }
            else
            {
                this.TimerBar.Value += 1;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimeTimer.Enabled = true;
            brdBottomCenter.Enabled = true;
            brdBottomLeft.Enabled = true;
            brdBottomRight.Enabled = true;
            brdCenterCenter.Enabled = true;
            brdCenterLeft.Enabled = true;
            brdCenterRight.Enabled = true;
            brdTopCenter.Enabled = true;
            brdTopLeft.Enabled = true;
            brdTopRight.Enabled = true;
        }

        public void Winner()
        {
            for (int i = 0; i < 8; i++)
            {
                string WinComb = "";

                switch (i)
                {
                    case 0:
                        WinComb = brdBottomCenter.Text + brdBottomLeft.Text + brdBottomRight.Text;
                        break;
                    case 1:
                        WinComb = brdCenterCenter.Text + brdCenterLeft.Text + brdCenterRight.Text;
                        break;
                    case 2:
                        WinComb = brdTopCenter.Text + brdTopLeft.Text + brdTopRight.Text;
                        break;
                    case 3:
                        WinComb = brdBottomLeft.Text + brdTopLeft.Text + brdCenterLeft.Text;
                        break;
                    case 4:
                        WinComb = brdTopCenter.Text + brdCenterCenter.Text + brdBottomCenter.Text;
                        break;
                    case 5:
                        WinComb = brdBottomRight.Text + brdCenterRight.Text + brdTopRight.Text;
                        break;
                    case 6:
                        WinComb = brdCenterCenter.Text + brdTopLeft.Text + brdBottomRight.Text;
                        break;
                    case 7:
                        WinComb = brdCenterCenter.Text + brdBottomLeft.Text + brdTopRight.Text;
                        break;
                }

                string Board = brdBottomCenter.Text + brdBottomLeft.Text + brdBottomRight.Text + brdCenterCenter.Text + brdCenterLeft.Text + brdCenterRight.Text + brdTopCenter.Text + brdTopLeft.Text + brdTopRight.Text;

                if (WinComb.Equals("XXX"))
                {
                    MessageBox.Show("Player X  has won the game", "Congratulations!", MessageBoxButtons.OK);
                    break;
                }
                else if (WinComb.Equals("OOO"))
                {
                    MessageBox.Show("Player O  has won the game", "Congratulations!", MessageBoxButtons.OK);
                    break;
                }
                else if (Board.Length == 9)
                {
                    MessageBox.Show("No Winner!", "Let's Try Again!", MessageBoxButtons.OK);
                    break;
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            brdBottomCenter.Text = "";
            brdBottomLeft.Text = "";
            brdBottomRight.Text = "";
            brdCenterCenter.Text = "";
            brdCenterLeft.Text = "";
            brdCenterRight.Text = "";
            brdTopCenter.Text = "";
            brdTopLeft.Text = "";
            brdTopRight.Text = "";
            Trn = 0;
            brdBottomCenter.Enabled = false;
            brdBottomLeft.Enabled = false;
            brdBottomRight.Enabled = false;
            brdCenterCenter.Enabled = false;
            brdCenterLeft.Enabled = false;
            brdCenterRight.Enabled = false;
            brdTopCenter.Enabled = false;
            brdTopLeft.Enabled = false;
            brdTopRight.Enabled = false;
        }
    }
}
