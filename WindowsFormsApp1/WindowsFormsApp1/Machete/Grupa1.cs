using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Machete
{
    public partial class Grupa1 : Form
    {
        public Grupa1()
        {
            InitializeComponent();
        }

        private void Grupa1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Macheta se incarca");
        }

        private void Grupa1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Macheta se inchide");
        }

        private void Grupa1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Macheta s-a inchis");
        }

        private void Grupa1_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Macheta se activeaza");
        }

        private void Grupa1_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Macheta se dezactiveaza");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
