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

namespace Pertemuan11_a
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=customer;Uid=root;Pwd=;");
        MySqlCommand command;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadData();
            conn.Close();
            txId.Enabled = true;
        }

        private void LoadData()
        {
            MySqlDataAdapter customerDA = new MySqlDataAdapter();
            string customerSelectSql = String.Concat("SELECT * FROM customer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, conn);
            DataSet ds = new DataSet();
            customerDA.Fill(ds);
            dgvDaftar.DataSource = ds.Tables[0].DefaultView;
            
        }
  
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string insertQuery = "INSERT INTO customer.customer(id,name,address,zip_code,phone_number,email) VALUES ('" + txId.Text + "','" + txName.Text + "','" + txAddress.Text + "','" + txZipCode.Text + "','" + txPhoneNumber.Text + "','" + txEmail.Text + "')";
            executeQuery(insertQuery);
            LoadData();
        }

        public void executeQuery(string query)
        {
            try
            {
                conn.Open();
                command = new MySqlCommand(query, conn);
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
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txId.Text = "";
            txName.Text = "";
            txAddress.Text = "";
            txZipCode.Text = "";
            txPhoneNumber.Text = "";
            txEmail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM customer.customer WHERE id = '" + txId.Text + "' ;";
            executeQuery(deleteQuery);
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Apakah anda ingin keluar ?", "Keluar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
