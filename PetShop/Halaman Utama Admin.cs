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
    public partial class Halaman_Utama_Admin : Form
    {
        public Halaman_Utama_Admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv aa = new dgv();
            aa.Show();
            this.Hide();
        }

        private void txtProduk_Click(object sender, EventArgs e)
        {
            order order = new order();
            order.Show();
            this.Hide();
        }

        private void Halaman_Utama_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }
}
