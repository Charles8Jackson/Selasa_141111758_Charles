using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name.ToString());
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(comboBoxFont.Text, richTextBox1.Font.Size);
            }
            catch { }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBoxSize.SelectedItem.ToString()));
            }
            catch { }
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Bold)
                baru = new Font(lama, lama.Style & ~FontStyle.Bold);
            else
                baru = new Font(lama, lama.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = baru;
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Italic)
                baru = new Font(lama, lama.Style & ~FontStyle.Italic);
            else
                baru = new Font(lama, lama.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = baru;
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Underline)
                baru = new Font(lama, lama.Style & ~FontStyle.Underline);
            else
                baru = new Font(lama, lama.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = baru;
        }

        private void fontColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog warna = new ColorDialog();
            warna.ShowDialog();
            richTextBox1.SelectionColor = warna.Color;
        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog buka = new OpenFileDialog();
            buka.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog simpan = new SaveFileDialog();
            simpan.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
