using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Muhammad_Dzalfiqri_S_015
{
    public partial class formClient : Form
    {
        

        public formClient()
        {
            InitializeComponent();
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new
            ServiceReference1.MatematikaClient();

            double c = double.Parse(Angka1.Text);
            double d = double.Parse(Angka2.Text);

            double hasilTambah = obj.Tambah(c, d);
            hBagi.Text = hasilTambah.ToString();

            double hasilKurang = obj.Kurang(c, d);
            hKurang.Text = hasilKurang.ToString();

            double hasilKali = obj.Kali(c, d);
            hKali.Text = hasilKali.ToString();

            double hasilBagi = obj.Bagi(c, d);
            hBagi.Text = hasilBagi.ToString();

            ServiceReference1.Koordinat a = new
            ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new
            ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;
            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
            Math.Pow(selisihY, 2));
        }
    }
}
