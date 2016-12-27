using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PointOfSale
{
    public partial class Barang : Form
    {
        MySqlConnection koneksi = new MySqlConnection("host=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        
        public Barang()
        {
            InitializeComponent();
        }

        public void bukaKoneksi()
        {
            if (koneksi.State == ConnectionState.Closed)
            {
                koneksi.Open();
            }
        }

        public void tutupKoneksi()
        {
            if (koneksi.State == ConnectionState.Open)
            {
                koneksi.Close();
            }
        }

        public void executeQuery(string query)
        {
            try
            {
                bukaKoneksi();
                command = new MySqlCommand(query, koneksi);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data telah diperbarui !");
                }
                else
                {
                    MessageBox.Show("Data tidak dapat diperbarui !");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tutupKoneksi();
            }
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO tabel_barang.tabelbarang(ID,Kode,Nama,Saldoawal,HargaHPP,Hargajual) VALUES ('" + txtid.Text + "','" + txtkode.Text + "','" + txtnama.Text + "','" + txtsaldoawal.Text + "','" + txthrghpp.Text + "','" + txthrgjual.Text + "')";
            executeQuery(insertQuery);  
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar ?", "Keluar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM tabel_barang.tabelbarang WHERE ID = " + txtid.Text;
            executeQuery(deleteQuery);
            txtid.Text = "";
            txtkode.Text = "";
            txtnama.Text = "";
            txtsaldoawal.Text = "";
            txthrghpp.Text = "";
            txthrgjual.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tabel_barang.tabelbarang SET ID='" + txtid.Text + "', Kode='" + txtkode.Text + "', Nama='" + txtnama.Text + "', Saldoawal='" + txtsaldoawal.Text + "', HargaHPP='" + txthrghpp.Text + "', Hargajual=" + txthrgjual.Text + " WHERE ID = " + txtid.Text;
            executeQuery(updateQuery);
        }
    }
}
