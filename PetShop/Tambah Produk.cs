﻿using System;
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
           input_hewan aa = new input_hewan();
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
            halaman_utama home = new halaman_utama();
            home.Show();
            this.Hide();
        }
    }
}
