﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_PABD
{
    public partial class Pemesanan : Form
    {
        public Pemesanan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            this.Hide();
            cust.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btPesan_Click(object sender, EventArgs e)
        {
            InfoRek info = new InfoRek();
            this.Hide();
            info.Show();
        }
    }
}
