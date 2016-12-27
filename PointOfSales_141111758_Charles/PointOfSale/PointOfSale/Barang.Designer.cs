namespace PointOfSale
{
    partial class Barang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtsaldoawal = new System.Windows.Forms.TextBox();
            this.txthrghpp = new System.Windows.Forms.TextBox();
            this.txthrgjual = new System.Windows.Forms.TextBox();
            this.Simpan = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Keluar = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo awal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga HPP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga jual :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(188, 48);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 6;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(188, 82);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(100, 20);
            this.txtkode.TabIndex = 7;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(188, 117);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 20);
            this.txtnama.TabIndex = 8;
            // 
            // txtsaldoawal
            // 
            this.txtsaldoawal.Location = new System.Drawing.Point(188, 151);
            this.txtsaldoawal.Name = "txtsaldoawal";
            this.txtsaldoawal.Size = new System.Drawing.Size(100, 20);
            this.txtsaldoawal.TabIndex = 9;
            // 
            // txthrghpp
            // 
            this.txthrghpp.Location = new System.Drawing.Point(188, 186);
            this.txthrghpp.Name = "txthrghpp";
            this.txthrghpp.Size = new System.Drawing.Size(100, 20);
            this.txthrghpp.TabIndex = 10;
            // 
            // txthrgjual
            // 
            this.txthrgjual.Location = new System.Drawing.Point(188, 218);
            this.txthrgjual.Name = "txthrgjual";
            this.txthrgjual.Size = new System.Drawing.Size(100, 20);
            this.txthrgjual.TabIndex = 11;
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(393, 66);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(158, 23);
            this.Simpan.TabIndex = 12;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(393, 149);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(158, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Keluar
            // 
            this.Keluar.Location = new System.Drawing.Point(393, 189);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(158, 23);
            this.Keluar.TabIndex = 14;
            this.Keluar.Text = "Keluar";
            this.Keluar.UseVisualStyleBackColor = true;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(393, 106);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(158, 23);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.txthrgjual);
            this.Controls.Add(this.txthrghpp);
            this.Controls.Add(this.txtsaldoawal);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Barang";
            this.Text = "Barang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtsaldoawal;
        private System.Windows.Forms.TextBox txthrghpp;
        private System.Windows.Forms.TextBox txthrgjual;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.Button update;
    }
}