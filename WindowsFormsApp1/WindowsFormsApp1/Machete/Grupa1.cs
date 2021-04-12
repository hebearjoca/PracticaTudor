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
            DataTable tabel1 = new DataTable();
            tabel1.Columns.Add("tip");
            tabel1.Columns.Add("denumire");
            tabel1.Columns.Add("valoare");
            DataRow rand1 = tabel1.NewRow();
            rand1["tip"] = "Spor";
            rand1["denumire"] = "spor de vechime";
            rand1["valoare"] = "500";
            DataRow rand2 = tabel1.NewRow();
            rand2["tip"] = "Spor";
            rand2["denumire"] = "spor de vechime";
            rand2["valoare"] = "500";
            treeList1.DataSource = tabel1;
        }

        private void Grupa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Char.ToUpper(e.KeyChar))
            {
                case 'C':
                    this.BackColor = Color.Aqua;
                    break;

                case 'A':
                    this.BackColor = Color.Coral;
                    break;

                case 'D':
                    this.BackColor = Color.Cyan;
                    break;

                default:
                    this.BackColor = Color.OrangeRed;
                    break;
            }
        }

        private void Grupa1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    this.BackColor = Color.Aqua;
                    break;

                case Keys.C:
                    this.BackColor = Color.Coral;
                    break;

                case Keys.D:
                    this.BackColor = Color.Cyan;
                    break;

                default:
                    this.BackColor = Color.OrangeRed;
                    break;
            }
        }
    }
}
