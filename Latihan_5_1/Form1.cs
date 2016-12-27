using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name.ToString());
            }

            TV.Nodes.Add("Color");
            TV.Nodes[0].Nodes.Add("Background color");
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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Bold)
                baru = new Font(lama, lama.Style & ~FontStyle.Bold);
            else
                baru = new Font(lama, lama.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = baru;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Italic)
                baru = new Font(lama, lama.Style & ~FontStyle.Italic);
            else
                baru = new Font(lama, lama.Style | FontStyle.Italic);
            richTextBox1.SelectionFont = baru;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font baru, lama;
            lama = richTextBox1.SelectionFont;
            if (lama.Underline)
                baru = new Font(lama, lama.Style & ~FontStyle.Underline);
            else
                baru = new Font(lama, lama.Style | FontStyle.Underline);
            richTextBox1.SelectionFont = baru;
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

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog warna = new ColorDialog();
            warna.ShowDialog();
            richTextBox1.SelectionColor = warna.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void TV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DialogResult warnaLatar = colorDialog1.ShowDialog();

            if (warnaLatar == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteCtrlDelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
