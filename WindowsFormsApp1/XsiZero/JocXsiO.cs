using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XsiZero
{
    public partial class JocXsiO : Form
    {
        public JocXsiO()
        {
            InitializeComponent();
        }

        // x = true este randul lui X; 
        // x = false este randul lui O        
        bool x = true;
        int numarApasari = 0;

        private void jocNouToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x = true;
            numarApasari = 0;
            foreach (Control c in this.Controls)
                if (c.GetType().Name == "Button")
                {
                    c.Enabled = true;
                    c.Text = "";
                }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By clasa a 12-a Tudor Vladimirescu", "X si O");
        }

        private void button_click(object sender, EventArgs e)
        {
            numarApasari++;

            if (x == true)
                ((Button)sender).Text = "X";
            else
                ((Button)sender).Text = "O";

            x = !x;
            ((Button)sender).Enabled = false;

            VerificareCastigator();
        }

        private void VerificareCastigator()
        {
            bool avemCastigator = false;
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                avemCastigator = true;
            else if (B1.Text ==  B2.Text && B2.Text == B3.Text && !B1.Enabled)
                avemCastigator = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                avemCastigator = true;
            else if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                avemCastigator = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                avemCastigator = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                avemCastigator = true;
            else if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                avemCastigator = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
                avemCastigator = true;

            if (avemCastigator)
            {
                //dezactivare butoane
                foreach (Control c in this.Controls)
                    if (c.GetType().Name == "Button")
                        c.Enabled = false;

                string castigator;
                if (x)
                    castigator = "O";
                else
                    castigator = "X";

                MessageBox.Show(castigator + " este castigator!!!");
            }
            else
                if (numarApasari==9)
                    MessageBox.Show("Nu a castigat nimeni!!!");
        }
    }
}
