using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teste
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonABC_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.IndianRed)
                ((Button)sender).BackColor = Color.Yellow;
            else
                ((Button)sender).BackColor = Color.IndianRed;
        }

        private void buttonStare_MouseEnter(object sender, EventArgs e)
        {
            buttonStare.BackColor = Color.YellowGreen;
            buttonStare.Text ="Butoane apasate";
        }

        private void buttonStare_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            buttonStare.BackColor = Color.Orange;
            buttonStare.Text = "Starea butoanelor";
        }

        private void buttonStare_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text ="";
            if (buttonA.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text +'A';
            if (buttonB.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text +'B';
            if (buttonC.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text +'C';
        }
    }
}
