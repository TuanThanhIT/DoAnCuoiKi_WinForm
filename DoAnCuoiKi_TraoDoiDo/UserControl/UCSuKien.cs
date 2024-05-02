﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCSuKien : UserControl
    {
        public UCSuKien()
        {
            InitializeComponent();
        }
        public UCSuKien(SuKien sk)
        {
            InitializeComponent();
            UCSKlblten.Text = sk.TenSuKien;
            UCSKlblGiamGia.Text = sk.GiamGia;
            UCSKlblBegin.Text = sk.BatDau;
            UCSKlblEnd.Text = sk.KetThuc;
        }

       
    }
}
