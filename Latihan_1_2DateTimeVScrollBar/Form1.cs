using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2DateTimeVScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl1.Text = vScrollBar1.Value.ToString();
            lbl2.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            lbl2.Text = vScrollBar2.Value.ToString();
            DateTime sekarang = new DateTime();
            sekarang = DateTime.Now;
            DateTime max = new DateTime();
            max = sekarang.AddYears(vScrollBar2.Value);
            dateTimePicker1.MaxDate = max;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = vScrollBar1.Value.ToString();
            lbl2.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbl1.Text = vScrollBar1.Value.ToString();
            DateTime sekarang = new DateTime();
            sekarang = DateTime.Now;
            DateTime min = new DateTime();
            min = sekarang.AddYears(-vScrollBar1.Value);
            dateTimePicker1.MinDate = min;
        }
    }
}
