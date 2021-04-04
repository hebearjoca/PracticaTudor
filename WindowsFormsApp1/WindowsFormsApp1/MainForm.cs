using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void grupa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machete.Grupa1 machetaGrupa1 = new Machete.Grupa1();
            machetaGrupa1.MdiParent = this;
            machetaGrupa1.Show();
        }

        private void grupa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Machete.Grupa2 machetaGrupa2 = new Machete.Grupa2();
            machetaGrupa2.MdiParent = this;
            machetaGrupa2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Machete.Grupa1 machetaGrupa1 = new Machete.Grupa1();
            machetaGrupa1.MdiParent = this;
            machetaGrupa1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Machete.Grupa1 machetaGrupa1 = new Machete.Grupa1();
            machetaGrupa1.MdiParent = this;
            machetaGrupa1.Show();
        }
    }
}
