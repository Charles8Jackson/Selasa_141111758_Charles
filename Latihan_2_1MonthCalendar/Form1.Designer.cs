namespace Latihan_2_1MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bulan = new System.Windows.Forms.DomainUpDown();
            this.day = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(114, 96);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bulan
            // 
            this.Bulan.Items.Add("Januari");
            this.Bulan.Items.Add("Februari");
            this.Bulan.Items.Add("Maret");
            this.Bulan.Items.Add("April");
            this.Bulan.Items.Add("Mei");
            this.Bulan.Items.Add("Juni");
            this.Bulan.Items.Add("Juli");
            this.Bulan.Items.Add("Agustus");
            this.Bulan.Items.Add("September");
            this.Bulan.Items.Add("Oktober");
            this.Bulan.Items.Add("November");
            this.Bulan.Items.Add("Desember");
            this.Bulan.Location = new System.Drawing.Point(245, 32);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(95, 20);
            this.Bulan.TabIndex = 3;
            this.Bulan.Text = "Bulan";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(154, 32);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(65, 20);
            this.day.TabIndex = 4;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.ValueChanged += new System.EventHandler(this.day_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 462);
            this.Controls.Add(this.day);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown Bulan;
        private System.Windows.Forms.NumericUpDown day;
    }
}

