namespace PasareZburatoare
{
    partial class JocPasareZburatoare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocPasareZburatoare));
            this.pasare = new System.Windows.Forms.PictureBox();
            this.canalJos = new System.Windows.Forms.PictureBox();
            this.pamant = new System.Windows.Forms.PictureBox();
            this.canalSus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pasare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canalJos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pamant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canalSus)).BeginInit();
            this.SuspendLayout();
            // 
            // pasare
            // 
            this.pasare.Image = ((System.Drawing.Image)(resources.GetObject("pasare.Image")));
            this.pasare.Location = new System.Drawing.Point(120, 204);
            this.pasare.Margin = new System.Windows.Forms.Padding(0);
            this.pasare.Name = "pasare";
            this.pasare.Size = new System.Drawing.Size(69, 50);
            this.pasare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pasare.TabIndex = 0;
            this.pasare.TabStop = false;
            // 
            // canalJos
            // 
            this.canalJos.Image = ((System.Drawing.Image)(resources.GetObject("canalJos.Image")));
            this.canalJos.Location = new System.Drawing.Point(512, 288);
            this.canalJos.Margin = new System.Windows.Forms.Padding(0);
            this.canalJos.Name = "canalJos";
            this.canalJos.Size = new System.Drawing.Size(68, 172);
            this.canalJos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canalJos.TabIndex = 1;
            this.canalJos.TabStop = false;
            // 
            // pamant
            // 
            this.pamant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pamant.Image = ((System.Drawing.Image)(resources.GetObject("pamant.Image")));
            this.pamant.Location = new System.Drawing.Point(-1, 461);
            this.pamant.Name = "pamant";
            this.pamant.Size = new System.Drawing.Size(880, 85);
            this.pamant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pamant.TabIndex = 2;
            this.pamant.TabStop = false;
            // 
            // canalSus
            // 
            this.canalSus.Image = ((System.Drawing.Image)(resources.GetObject("canalSus.Image")));
            this.canalSus.Location = new System.Drawing.Point(620, 0);
            this.canalSus.Margin = new System.Windows.Forms.Padding(0);
            this.canalSus.Name = "canalSus";
            this.canalSus.Size = new System.Drawing.Size(63, 179);
            this.canalSus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canalSus.TabIndex = 3;
            this.canalSus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCOR: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canalSus);
            this.Controls.Add(this.pamant);
            this.Controls.Add(this.canalJos);
            this.Controls.Add(this.pasare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pasare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canalJos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pamant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canalSus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pasare;
        private System.Windows.Forms.PictureBox canalJos;
        private System.Windows.Forms.PictureBox pamant;
        private System.Windows.Forms.PictureBox canalSus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

