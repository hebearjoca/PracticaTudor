namespace teste
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTextNou = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCuloare = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTextNou,
            this.toolStripButtonFont,
            this.toolStripButtonCuloare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(155, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseUp);
            // 
            // toolStripButtonTextNou
            // 
            this.toolStripButtonTextNou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTextNou.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTextNou.Image")));
            this.toolStripButtonTextNou.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTextNou.Name = "toolStripButtonTextNou";
            this.toolStripButtonTextNou.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonTextNou.Text = "Text nou";
            this.toolStripButtonTextNou.Click += new System.EventHandler(this.toolStripButtonTextNou_Click);
            // 
            // toolStripButtonFont
            // 
            this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFont.Image")));
            this.toolStripButtonFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFont.Name = "toolStripButtonFont";
            this.toolStripButtonFont.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonFont.Text = "Font";
            this.toolStripButtonFont.Click += new System.EventHandler(this.toolStripButtonFont_Click);
            // 
            // toolStripButtonCuloare
            // 
            this.toolStripButtonCuloare.AutoSize = false;
            this.toolStripButtonCuloare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCuloare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCuloare.Image")));
            this.toolStripButtonCuloare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCuloare.Name = "toolStripButtonCuloare";
            this.toolStripButtonCuloare.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonCuloare.Text = "Culoare";
            this.toolStripButtonCuloare.Click += new System.EventHandler(this.toolStripButtonCuloare_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(111, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(766, 363);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form12";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTextNou;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonCuloare;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

