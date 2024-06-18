using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPPPPPPPPPPPPPPPPPPPPPPPPedric
{
    public partial class Form1 : Form
    {
        byte numRandom;
        byte numPredic;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            numRandom = (byte)ran.Next(1,9);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
           Application.Exit();

        }

        private void tGetNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numPredic = Convert.ToByte(tGetNumber.Text);
                if (numPredic == numRandom)
                {
                    laShow.Text = "ชนะกูเฉยยยยยย";
                    laShow.ForeColor = System.Drawing.Color.LawnGreen;
                }
                else
                {
                    if (numPredic > numRandom)
                    {
                        laShow.Text = "น้อยขึ้นอีกไอ้ควาย";
                        laShow.ForeColor = System.Drawing.Color.Red;
                        tGetNumber.Text = string.Empty;
                        tGetNumber.Select();
                    }
                    else if (numPredic < numRandom)
                    {
                        laShow.Text = "เพิ่มลงอีกไอ้ควาย";
                        laShow.ForeColor = System.Drawing.Color.Red;
                        tGetNumber.Text = string.Empty;
                        tGetNumber.Select();

                    }
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            numRandom = (byte)ran.Next(1, 9);
        }
    }
}
