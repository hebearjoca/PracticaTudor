namespace teste
{
    partial class Form10
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
            this.lista_fisiere = new System.Windows.Forms.ListView();
            this.calea_curenta = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista_fisiere
            // 
            this.lista_fisiere.HideSelection = false;
            this.lista_fisiere.Location = new System.Drawing.Point(3, 408);
            this.lista_fisiere.Name = "lista_fisiere";
            this.lista_fisiere.Size = new System.Drawing.Size(792, 41);
            this.lista_fisiere.TabIndex = 0;
            this.lista_fisiere.UseCompatibleStateImageBehavior = false;
            // 
            // calea_curenta
            // 
            this.calea_curenta.AutoSize = true;
            this.calea_curenta.Location = new System.Drawing.Point(15, 374);
            this.calea_curenta.Name = "calea_curenta";
            this.calea_curenta.Size = new System.Drawing.Size(0, 13);
            this.calea_curenta.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(440, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.calea_curenta);
            this.Controls.Add(this.lista_fisiere);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_fisiere;
        private System.Windows.Forms.Label calea_curenta;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}