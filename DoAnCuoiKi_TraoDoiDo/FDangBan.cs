using DoAnCuoiKi_TraoDoiDo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormDangBan : Form
    {
        FormDAO fd = new FormDAO();
        BanDoBUS bds = new BanDoBUS();

        public FormDangBan()
        {
            InitializeComponent();
        }
        private void FormDangBan_Load(object sender, EventArgs e)
        {
            gvDangban.DataSource = bds.DanhSachDangBan();
        }



        private void btnDangbanThem_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormBanDo(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Bán Đồ";
            }
            else
            {
                fd.OpenChildForm(new FormBanDo(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Bán Đồ";
            }
        }

        private void btnDbChinhsua_Click(object sender, EventArgs e)
        {
            BanDoBUS.checkButton = false;
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormBanDo(this), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Bán Đồ";
            }
            else
            {
                fd.OpenChildForm(new FormBanDo(this), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Bán Đồ";
            }
        }

        private void btnDbXoa_Click(object sender, EventArgs e)
        {
            BanDo bd = new BanDo(lblTen.Text);
            if (bds.XoaMatHang(bd) == true)
            {
                MessageBox.Show("Mặt hàng này sẽ bị gỡ xuống");
                FormDangBan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi. Không thể gỡ mặt hàng của bạn xuống");
            }
        }


        private void gvDangban_CellClick_3(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvDangban.Rows[e.RowIndex];

                    lblTen.Text = row.Cells[0].Value.ToString();
                    lblLoai.Text = row.Cells[1].Value.ToString();
                    lblGiaban.Text = row.Cells[2].Value.ToString();
                    lblMota.Text = row.Cells[3].Value.ToString();
                    lblAnh1.Text = row.Cells[4].Value.ToString();
                    lblAnh2.Text = row.Cells[5].Value.ToString();
                    lblAnh3.Text = row.Cells[6].Value.ToString();
                    lblAnh4.Text = row.Cells[7].Value.ToString();
                    lblMaVoucher.Text = row.Cells[8].Value.ToString();
                    lblGiamgia.Text = row.Cells[9].Value.ToString();
                    lblSlVou.Text = row.Cells[10].Value.ToString();
                    lblSoluong.Text = row.Cells[11].Value.ToString();
                    lblDiadiem.Text = row.Cells[12].Value.ToString();
                    lblPtGiaohang.Text = row.Cells[13].Value.ToString();
                    lblTinhtrang.Text = row.Cells[14].Value.ToString();
                    lblMaSP.Text = row.Cells[15].Value.ToString();
                    lblNgay.Text = row.Cells[16].Value.ToString();
                    lblID.Text = row.Cells[17].Value.ToString();
                    lblGiagoc.Text = row.Cells[18].Value.ToString();
                }
            }
            catch { }
        }

        private void btnDbQuaylai_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormBanDo(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Mặt hàng";
            }
            else
            {
                fd.OpenChildForm(new FormBanDo(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Mặt hàng";
            }
        }
    }
}

