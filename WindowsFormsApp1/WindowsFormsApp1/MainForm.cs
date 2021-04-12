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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Machete.Grupa1 machetaGrupa1 = new Machete.Grupa1();
            machetaGrupa1.MdiParent = this;
            machetaGrupa1.Show();
        }

    }
}
