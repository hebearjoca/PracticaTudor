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
        int vitezaSusJos = 12;
        int scor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pasare.Top += vitezaSusJos;
            canalJos.Left -= vitezaStangaDreapta;
            canalSus.Left -= vitezaStangaDreapta;
            canalJos2.Left -= vitezaStangaDreapta;
            canalSus2.Left -= vitezaStangaDreapta;
            Coin.Left -= vitezaStangaDreapta;
            Coin2.Left -= vitezaStangaDreapta;
            Bomb.Left -= vitezaStangaDreapta;
            Pizza.Left -= vitezaStangaDreapta;

            label1.Text = "SCOR: " + scor.ToString();

            if (canalJos.Left < -70)
            {
                canalJos.Left = 900;
                scor += 5;
            }
            if (canalJos2.Left < -70)
            {
                canalJos2.Left = 1000;
                scor += 5;
            }
            if (canalSus.Left < -70)
            {
                canalSus.Left = 1100;
                scor += 5;
            }
            if (canalSus2.Left < -70)
            {
                canalSus2.Left = 1200;
                scor += 5;
            }
            if (Coin.Left  < -70)
            {
                Coin.Left = 2050;
            }
            if (Coin2.Left < -70)
            {
                Coin2.Left = 2050;
            }
            if (Bomb.Left < -70)
            {
                Bomb.Left = 5555;
            }
            if (Pizza.Left < -70)
            {
                Pizza.Left = 9999;
            }


            if (pasare.Bounds.IntersectsWith(canalSus.Bounds)
                || pasare.Bounds.IntersectsWith(canalJos.Bounds)
                || pasare.Bounds.IntersectsWith(canalJos2.Bounds)
                || pasare.Bounds.IntersectsWith(canalSus2.Bounds)
                || pasare.Bounds.IntersectsWith(Bomb.Bounds)
                || pasare.Bounds.IntersectsWith(pamant.Bounds)
                || pasare.Top < -1)
                JocTerminat();

            if (pasare.Bounds.IntersectsWith(Coin.Bounds))
            {
                scor += 50;
                Coin.Left = 2050;
            }

            if (pasare.Bounds.IntersectsWith(Coin2.Bounds))
            {
                scor += 50;
                Coin2.Left = 2050;
            }
            if (pasare.Bounds.IntersectsWith(Pizza.Bounds))
            {
                scor += 500;
                Pizza.Left = 9999;
                canalJos.Left = 5900;
                canalJos2.Left = 6000;
                vitezaStangaDreapta += 10;    //as vrea sa fie ca un powerup si sa ii dea viteza numai pentru un anumit interval de timp 
            }
            // incerc sa fixez suprapunerile obiectelor

            if (Coin2.Bounds.IntersectsWith(Bomb.Bounds)
                || Coin2.Bounds.IntersectsWith(canalJos2.Bounds)
                || Coin2.Bounds.IntersectsWith(canalJos.Bounds))
                Coin2.Left += 100;

            if (Coin.Bounds.IntersectsWith(canalSus.Bounds)
                || Coin.Bounds.IntersectsWith(canalSus2.Bounds))
                Coin.Left += 100;

            if (canalSus.Bounds.IntersectsWith(canalSus2.Bounds))
                canalSus.Left += 100;
            if (canalJos.Bounds.IntersectsWith(canalJos2.Bounds))
                canalJos.Left += 100;
            if (Bomb.Bounds.IntersectsWith(canalJos.Bounds)
                || Bomb.Bounds.IntersectsWith(canalJos2.Bounds))
                Bomb.Left += 200;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vitezaSusJos = -10;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                vitezaSusJos = 12;
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

        private void JocPasareZburatoare_Load(object sender, EventArgs e)
        {

        }

        private void canalJos2_Click(object sender, EventArgs e)
        {

        }
    }
}
