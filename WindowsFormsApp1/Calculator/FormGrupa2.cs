using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormGrupa2 : Form
    {
        public FormGrupa2()
        {
            InitializeComponent();
        }

        Double rezultat = 0;
        string operatie;
         
        private void eliminareZero()
        {
            double numar;
            numar = double.Parse(textBoxAfisare.Text);
            textBoxAfisare.Text = numar.ToString();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "0";
            eliminareZero();
        }

        private void buttonUnu_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "1";
            eliminareZero();
        }

        private void buttonDoi_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "2";
            eliminareZero();
        }

        private void buttonTrei_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "3";
            eliminareZero();
        }

        private void buttonPatru_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "4";
            eliminareZero();
        }

        private void buttonCinci_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "5";
            eliminareZero();
        }

        private void buttonSase_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "6";
            eliminareZero();
        }

        private void buttonSapte_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "7";
            eliminareZero();
        }

        private void buttonOpt_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "8";
            eliminareZero();
        }

        private void buttonNoua_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "9";
            eliminareZero();
        }

        private void buttonStergeTot_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text = "";
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
             
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            rezultat = Double.Parse(textBoxAfisare.Text);
            textBoxAfisare.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "-";
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "*";
        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text += "/";
        }

        private void buttonStergeCaracter_Click(object sender, EventArgs e)
        {
            string textCurent = textBoxAfisare.Text;
            if (textCurent.Length > 0)
                textCurent = textCurent.Remove(textCurent.Length, 1);
            textBoxAfisare.Text = textCurent;
        }
    }
}
