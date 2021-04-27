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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
    
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (
                checkBox1.CheckState == CheckState.Checked &&
                checkBox2.CheckState == CheckState.Checked &&
                checkBox3.CheckState == CheckState.Checked &&
                checkBox5.CheckState == CheckState.Checked &&
                checkBox4.CheckState == CheckState.Checked
                 )
                MessageBox.Show("Raspunsul la prima intrebare este CORECT");
            else
                MessageBox.Show("Indicatie > Daca punem un sac in altul....");

            if (checkBox8.CheckState == CheckState.Checked
                && checkBox6.CheckState == CheckState.Unchecked
                && checkBox7.CheckState == CheckState.Unchecked
                && checkBox9.CheckState == CheckState.Unchecked)
                MessageBox.Show("Raspunsul la cea de-a doua intrebare este CORECT");
            else
                MessageBox.Show("Raspunsul la cea de-a doua intrebare este Gresit");

            label2.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
        }
    }
}
