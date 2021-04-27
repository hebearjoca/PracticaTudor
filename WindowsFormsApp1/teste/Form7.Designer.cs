namespace teste
{
    partial class Form7
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonStare = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(86, 103);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(47, 37);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonABC_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(153, 103);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(47, 37);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(226, 103);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(46, 37);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonStare
            // 
            this.buttonStare.Location = new System.Drawing.Point(370, 187);
            this.buttonStare.Name = "buttonStare";
            this.buttonStare.Size = new System.Drawing.Size(188, 23);
            this.buttonStare.TabIndex = 3;
            this.buttonStare.Text = "Starea butoanelor";
            this.buttonStare.UseVisualStyleBackColor = true;
            this.buttonStare.Click += new System.EventHandler(this.buttonStare_Click);
            this.buttonStare.MouseEnter += new System.EventHandler(this.buttonStare_MouseEnter);
            this.buttonStare.MouseLeave += new System.EventHandler(this.buttonStare_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Afiseaza starea butoanelor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introducere parola";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStare);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonStare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}