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
    public partial class FormDoEmBe : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormDoEmBe()
        {
            InitializeComponent();
        }
        string loaimathang = "Do em be";

        private void FormDoEmBe_Load_1(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPDobaby);
        }
    }
}
