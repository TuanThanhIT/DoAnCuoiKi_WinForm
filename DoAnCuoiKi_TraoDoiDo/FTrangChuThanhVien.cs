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
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormTrangChuThanhVien : Form
    {
        FormBUS fd = new FormBUS(); 
        public FormTrangChuThanhVien(DangKi dk)
        {
            InitializeComponent();
            lblTrangchuTen.Text = dk.Tên_đăng_nhập;
            lblTrangChuChucvu.Text = dk.Chức_vụ;
            lblTrangChuID.Text = dk.ID;
            DangKiDAO.ID = lblTrangChuID.Text;
            DangKiDAO.Ten_nguoi_dung = lblTrangchuTen.Text;
            DangKiDAO.Chuc_vu = lblTrangChuChucvu.Text;
            DangKiDAO.Ho_ten = dk.Họ_tên;
            DangKiDAO.Dia_chi = dk.Địa_chỉ;
            DangKiDAO.So_dt = dk.Số_điện_thoại;
        }
        public FormTrangChuThanhVien()
        {
            InitializeComponent();
            
        }


        private void FormTrangChuThanhVien_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), panelTVTrangChu);
            lblTVChude.Text = "Trang Chủ";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMain(), panelTVTrangChu);
            lblTVChude.Text = "Trang Chủ";
        }

        private void btnBanDo_Click(object sender, EventArgs e)
        {
            BanDoBUS.checkButton = true;
            fd.OpenChildForm(new FormBanDo(), panelTVTrangChu);
            lblTVChude.Text = "Bán Hàng";
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMatHang(), panelTVTrangChu);
            lblTVChude.Text = "Mặt Hàng";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLichSu(), panelTVTrangChu);
            lblTVChude.Text = "Lịch Sử";
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {

            fd.OpenChildForm(new FormGioHang(), panelTVTrangChu);
            lblTVChude.Text = "Giỏ Hàng";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
