using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teste
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            ConstruiesteHeader();

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            string radacina = "C:\\";
            this.calea_curenta.Text = radacina + "(Doublu Click pe folder)";
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(radacina);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            this.lista_fisiere.Items.Clear();
            this.lista_fisiere.BeginUpdate();
            foreach (System.IO.DirectoryInfo fi in dirs)
            {
                lvi = new ListViewItem();
                lvi.Text = fi.Name;
                lvi.ImageIndex = 1;
                lvi.Tag = fi.FullName;

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = "";
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi.LastAccessTime.ToString();
                lvi.SubItems.Add(lvsi);

                this.lista_fisiere.Items.Add(lvi);
            }

        }

        private void ConstruiesteHeader()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Nume fisier";
            this.lista_fisiere.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Dimensiune";
            this.lista_fisiere.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ultima accesare";
            this.lista_fisiere.Columns.Add(colHead);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text = "Interval selectat: Start = "+e.Start.ToShortDateString() + " : End = "+e.End.ToShortDateString();
            if (e.Start.ToShortDateString() == e.End.ToShortDateString())
            {
                String x = e.Start.ToShortDateString();
                if (!(comboBox1.Items.Contains(x)))
                    comboBox1.Items.Add(e.End.ToShortDateString());
            }

        }
    }
}
