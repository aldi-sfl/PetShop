using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class halaman_utama : Form
    {
        public halaman_utama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void halaman_utama_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btproduk_Click(object sender, EventArgs e)
        {
            produk keproduk = new produk();
            keproduk.Show();
            this.Hide();
        }

        private void bttransaksi_Click(object sender, EventArgs e)
        {
            pembayaran kebayar = new pembayaran();
            kebayar.Show();
            this.Hide();
        }

        private void btkeluar_Click(object sender, EventArgs e)
        {
            Form1 keluar = new Form1();
            keluar.Show();
            this.Hide();
        }
    }
}
