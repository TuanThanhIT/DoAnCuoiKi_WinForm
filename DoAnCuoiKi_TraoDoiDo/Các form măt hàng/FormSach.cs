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
    public partial class FormSach : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormSach()
        {
            InitializeComponent();
        }
        string loaimathang = "Sach";
        private void FormSach_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPSach);
        }
    }
}
