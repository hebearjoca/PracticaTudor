using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPU_RAM_monitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fCPU = pCPU.NextValue();
            float fRAM = pRam.NextValue();
            metroProgressBarCPU.Value = (int)fCPU;
            metroProgressBarRAM.Value = (int)fRAM;
            lblCPU.Text = String.Format("{0:0.00}%", fCPU);
            lblRAM.Text = String.Format("{0:0.00}%", fRAM);

            chart1.Series["RAM"].Points.AddY(fRAM);
            chart1.Series["CPU"].Points.AddY(fCPU);
        }
    }
}
