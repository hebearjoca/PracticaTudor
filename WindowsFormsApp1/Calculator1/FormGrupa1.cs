using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class FormGrupa1 : Form
    {
        public FormGrupa1()
        {
            InitializeComponent();
        }

        Double rezultat = 0;
        string operatie="";
        bool butonOperatieApasat = false;

        private void EliminareZero()
        {
            if (textBoxAfisare.Text == "0")
                textBoxAfisare.Text = "";
        }

        private void buttonCifra_Click(object sender, EventArgs e)
        {
            EliminareZero();
            if (butonOperatieApasat == true)
                textBoxAfisare.Text = "";
            butonOperatieApasat = false;
            string cifra = ((Button)sender).Text;
            textBoxAfisare.Text += cifra;
        }
        
        private void buttonEgal_Click(object sender, EventArgs e)
        {
            label1.Text +=" "+ textBoxAfisare.Text + " = ";
            switch (operatie)
            {
                case "+":
                    textBoxAfisare.Text = (rezultat + double.Parse(textBoxAfisare.Text)).ToString();
                    rezultat = 0;
                    break;
                case "-":
                    textBoxAfisare.Text = (rezultat - double.Parse(textBoxAfisare.Text)).ToString();
                    rezultat = 0;
                    break;
                case "x":
                    textBoxAfisare.Text = (rezultat * double.Parse(textBoxAfisare.Text)).ToString();
                    rezultat = 0;
                    break;
                case "/":
                    textBoxAfisare.Text = (rezultat / double.Parse(textBoxAfisare.Text)).ToString();
                    rezultat = 0;
                    break;
            }
        }

        private void buttonStergeCaracter_Click(object sender, EventArgs e)
        {
            string textCurent = textBoxAfisare.Text;
            if (textCurent.Length == 1)
                textBoxAfisare.Text = "0";
            else
            {
                if (textCurent.Length > 0)
                    textCurent = textCurent.Remove(textCurent.Length - 1, 1);
                textBoxAfisare.Text = textCurent;
            }
        }

        private void buttonOperatie_Click(object sender, EventArgs e)
        {
            if (rezultat != 0)
            {
                buttonEgal.PerformClick();
                operatie = ((Button)sender).Text;
                label1.Text = rezultat.ToString() + " " + operatie;
                butonOperatieApasat = true;
            }

            rezultat = double.Parse(textBoxAfisare.Text);
            operatie = ((Button)sender).Text;
            label1.Text = rezultat.ToString() + " " + operatie;
            butonOperatieApasat = true;
        }

        private void buttonStergeTot_Click(object sender, EventArgs e)
        {
            textBoxAfisare.Text = "0";
            label1.Text = "";
            operatie = "";
            rezultat = 0;
        }
    }
}
