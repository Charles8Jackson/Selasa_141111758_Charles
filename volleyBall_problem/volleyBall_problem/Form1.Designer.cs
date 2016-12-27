namespace volleyBall_problem
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.TxtHsl = new System.Windows.Forms.TextBox();
            this.BtnHtg = new System.Windows.Forms.Button();
            this.BtnHps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "VOLLEYBALL PROBLEM MATCH";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score B";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(212, 112);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 3;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(212, 171);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 4;
            // 
            // TxtHsl
            // 
            this.TxtHsl.Location = new System.Drawing.Point(323, 139);
            this.TxtHsl.Name = "TxtHsl";
            this.TxtHsl.Size = new System.Drawing.Size(100, 20);
            this.TxtHsl.TabIndex = 5;
            // 
            // BtnHtg
            // 
            this.BtnHtg.Location = new System.Drawing.Point(152, 230);
            this.BtnHtg.Name = "BtnHtg";
            this.BtnHtg.Size = new System.Drawing.Size(75, 23);
            this.BtnHtg.TabIndex = 6;
            this.BtnHtg.Text = "Hitung";
            this.BtnHtg.UseVisualStyleBackColor = true;
            this.BtnHtg.Click += new System.EventHandler(this.BtnHtg_Click);
            // 
            // BtnHps
            // 
            this.BtnHps.Location = new System.Drawing.Point(296, 230);
            this.BtnHps.Name = "BtnHps";
            this.BtnHps.Size = new System.Drawing.Size(75, 23);
            this.BtnHps.TabIndex = 7;
            this.BtnHps.Text = "Hapus";
            this.BtnHps.UseVisualStyleBackColor = true;
            this.BtnHps.Click += new System.EventHandler(this.BtnHps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 455);
            this.Controls.Add(this.BtnHps);
            this.Controls.Add(this.BtnHtg);
            this.Controls.Add(this.TxtHsl);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox TxtHsl;
        private System.Windows.Forms.Button BtnHtg;
        private System.Windows.Forms.Button BtnHps;
    }
}

