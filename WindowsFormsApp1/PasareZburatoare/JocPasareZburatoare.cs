using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasareZburatoare
{
    public partial class JocPasareZburatoare : Form
    {
        public JocPasareZburatoare()
        {
            InitializeComponent();
        }

        int vitezaStangaDreapta = 8;
        int vitezaSusJos = 6;
        int scor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pasare.Top += vitezaSusJos;
            canalJos.Left -= vitezaStangaDreapta;
            canalSus.Left -= vitezaStangaDreapta;
            label1.Text = "SCOR: " + scor.ToString();

            if (canalJos.Left < -70)
            {
                canalJos.Left = 900;
                scor += 5;
            }
            if (canalSus.Left < -70)
            {
                canalSus.Left = 1000;
                scor += 5;
            }

            if (pasare.Bounds.IntersectsWith(canalSus.Bounds)
                || pasare.Bounds.IntersectsWith(canalJos.Bounds)
                || pasare.Bounds.IntersectsWith(pamant.Bounds)
                || pasare.Top < -1)
                JocTerminat(); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vitezaSusJos = -6;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vitezaSusJos = 6;
            if (e.KeyCode == Keys.Right)
                vitezaStangaDreapta += 5;
            if (e.KeyCode == Keys.Left)
                vitezaStangaDreapta = (vitezaStangaDreapta - 5 >= 8 ? vitezaStangaDreapta - 5 : vitezaStangaDreapta);
        }

        private void JocTerminat()
        {
            timer1.Stop();
            label1.Text += "  JOC TERMINAT!!!";
        }
    }
}
