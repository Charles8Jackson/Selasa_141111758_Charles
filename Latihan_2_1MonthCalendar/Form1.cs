using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bulan.SelectedItem = "Januari";
            DateTime mulai = new DateTime(2016, 1, 1);
            DateTime akhir = new DateTime(2017, 12, 31);
            TimeSpan jarak = akhir - mulai;
            int day = jarak.Days;
            for (var i = 0; i <= day; i++) {
                var bolddate = mulai.AddDays(i);
                switch (bolddate.DayOfWeek) {
                    case DayOfWeek.Thursday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                    case DayOfWeek.Friday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                }
            }
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1998, 08, 28));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, Bulan.SelectedIndex + 1, Convert.ToInt32(day.Value)));
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, Bulan.SelectedIndex + 1, Convert.ToInt32(day.Value)));
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
