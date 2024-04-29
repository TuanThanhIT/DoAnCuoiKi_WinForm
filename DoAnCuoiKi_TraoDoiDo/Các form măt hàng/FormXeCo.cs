﻿using DoAnCuoiKi_TraoDoiDo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormXeCo : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormXeCo()
        {
            InitializeComponent();
        }
        string loaimathang = "Xe co";
        private void FormXeCo_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPXeco);
        }
    }
}
