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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void toolStripButtonTextNou_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Color = Color.IndianRed;
            fd.ShowApply = true;
            //fd.Apply += Fd_Apply;//new EventHandler(ApplyFont);
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.richTextBox1.Font = fd.Font;
                this.richTextBox1.ForeColor = fd.Color;
            }
        }

        private void toolStripButtonCuloare_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = Color.DarkBlue;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.richTextBox1.ForeColor = cd.Color;

        }
        bool am_apasat;
        Point forma_deplasata;
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            // am apasat butonul de mouse pe toolbar
            am_apasat = true;
            forma_deplasata = new Point(e.X, e.Y);
            toolStrip1.Capture = true;

        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            am_apasat = false;
            toolStrip1.Capture = false;

        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (am_apasat)
            {
                if (toolStrip1.Dock == DockStyle.Top || toolStrip1.Dock == DockStyle.Left)
                {
                    // daca depaseste atunci duc in stanga sus
                    if (forma_deplasata.X < (e.X - 20) || forma_deplasata.Y < (e.Y - 20))
                    {
                        am_apasat = false;
                        // Disconect toolbar
                        toolStrip1.Dock = DockStyle.None;
                        toolStrip1.Location = new Point(10, 10);
                        toolStrip1.Size = new Size(200, 45);
                        //toolStrip1.bor = BorderStyle.FixedSingle;
                    }
                }
                else
                if (toolStrip1.Dock == DockStyle.None)
                {
                    toolStrip1.Left = e.X + toolStrip1.Left - forma_deplasata.X;
                    toolStrip1.Top = e.Y + toolStrip1.Top - forma_deplasata.Y;
                    if (toolStrip1.Top < 5 || toolStrip1.Top > this.Size.Height - 20)
                    {
                        am_apasat = false;
                        toolStrip1.Dock = DockStyle.Top;
                        //toolStrip1.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else if (toolStrip1.Left < 5 || toolStrip1.Left > this.Size.Width - 20)
                    {
                        am_apasat = false;
                        toolStrip1.Dock = DockStyle.Left;
                        //toolStrip1.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
