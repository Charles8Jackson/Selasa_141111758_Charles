using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog coba = new FontDialog();
            if (coba.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = coba.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog warna = new ColorDialog();
            warna.ShowDialog();
            richTextBox1.SelectionColor = warna.Color;
        }
    }
}
