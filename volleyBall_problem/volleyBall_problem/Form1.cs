using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyBall_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int Mod = 1000000007;

        static bool nilaiValid(int a, int b)
        {
            if (a < 25)
                return false;
            if (a == 25)
                return b <= 23;
            return b == (a - 2);
        }

        private void BtnHtg_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(Txt1.Text);
            var b = Convert.ToInt32(Txt2.Text);

            int hasil;

            if (a < b) Swap(ref a, ref b);

            if (!nilaiValid(a, b))
            {
                hasil = 0;
            }
            else
            {
                if (a > 25)
                {
                    hasil = nCr(24, 24, Mod);
                    hasil = (int)((((long)hasil) * pow(2, b - 24, Mod)) % Mod);
                }
                else
                {
                    hasil = nCr(a - 1, b, Mod);
                }
            }
            TxtHsl.Text = hasil.ToString();
        }

        public static void Swap<T>(ref T kiri, ref T kanan)
        {
            T temp;
            temp = kiri;
            kiri = kanan;
            kanan = temp;
        }

        public static int nCr(int n, int r, int mod)
        {
            if (n < r)
                Swap(ref n, ref r);

            if (n < 1 || r < 1)
                return 1;

            var row = new int[r];

            for (var i = 0; i < r; row[i++] = 1)
            { }

            for (int i = 2; i < r; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
            }

            --r;
            int jumlah = row[r];

            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
                jumlah = (jumlah + row[r]) % mod;
            }
            return jumlah;
        }

        private static int pow(int baseNo, int exp, int mod)
        {
            if (exp < 2)
            {
                return (exp < 1) ? 1 : baseNo;
            }

            long product = pow(baseNo, exp >> 1, mod);

            product = (product * product) % mod;

            return
                ((exp & 1) == 1) ? (int)((product * baseNo) % mod) : (int)(product);
        }

        private void BtnHps_Click(object sender, EventArgs e)
        {
            Txt1.Clear();
            Txt2.Clear();
            TxtHsl.Clear();
        }
    }
}

