using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
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
using System.Web;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormBanDo : Form
    {
        FormBUS fd = new FormBUS();
        BanDoBUS bds = new BanDoBUS();
        public FormBanDo(FormDangBan f)
        {
            InitializeComponent();
            List<string> imagePaths = new List<string>();
            if (BanDoBUS.checkButton == false)
            {
                txtBdTenMH.Text = f.lblTen.Text;
                comboBdLoaiMH.Text = f.lblLoai.Text;
                txtBdGiaban.Text = f.lblGiaban.Text;
                txtBdMota.Text = f.lblMota.Text;
                imagePaths.Add(f.lblAnh1.Text);
                imagePaths.Add(f.lblAnh2.Text);
                imagePaths.Add(f.lblAnh3.Text);
                imagePaths.Add(f.lblAnh4.Text);
                txtBdMa.Text = f.lblMaVoucher.Text;
                txtBdGiamgia.Text = f.lblGiamgia.Text;
                txtBdSlVou.Text = f.lblSlVou.Text;
                txtBdSoluong.Text = f.lblSoluong.Text;
                txtBdDiadiem.Text = f.lblDiadiem.Text;
                bds.ptGiaoHang2(rdBChuyenPhatNhanh, rdBNguoibangiao, rdBGiaohangtructiep, f.lblPtGiaohang.Text);
                cbBoxTinhtrang.Text = f.lblTinhtrang.Text;
                txtBDMaSP.Text = f.lblMaSP.Text;
                bds.ngayDangBan(dateTimeNgayban, f.lblNgay.Text);
                txtDbGiaGoc.Text = f.lblGiagoc.Text;
                bds.LoadImage2(picImage, txtImagePath, imagePaths);
            }


        }

        public FormBanDo()
        {
            InitializeComponent();
        }

        private void btnBdHoantat_Click_1(object sender, EventArgs e)
        {
            string phuongthucGiaoHang = bds.ptGiaoHang(rdBChuyenPhatNhanh, rdBGiaohangtructiep, rdBNguoibangiao);
            string maSanPham = bds.RandomMaSanPham();
            BanDo banDo = new BanDo(txtBdTenMH.Text, comboBdLoaiMH.Text, txtBdGiaban.Text, txtBdMota.Text, bds.ImagePaths[0], bds.ImagePaths[1],
                     bds.ImagePaths[2], bds.ImagePaths[3], txtBdMa.Text, txtBdGiamgia.Text, txtBdSlVou.Text, txtBdSoluong.Text, txtBdDiadiem.Text, phuongthucGiaoHang, cbBoxTinhtrang.Text, maSanPham, dateTimeNgayban.Value.ToShortDateString(), DangKiDAO.ID, txtDbGiaGoc.Text);
            if (bds.ThemMatHang(banDo))
            {
                DialogResult result = MessageBox.Show("Bạn đã đăng bán thành công. Bạn có muốn đăng bán mặt hàng khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    if (DangKiDAO.Chuc_vu == "Quan tri vien")
                    {
                        fd.OpenChildForm(new FormDangBan(), FormTrangChu.panelTrangChu);
                        FormTrangChu.lblChude.Text = "Đang Bán";
                    }
                    else
                    {
                        fd.OpenChildForm(new FormDangBan(), FormTrangChuThanhVien.panelTVTrangChu);
                        FormTrangChuThanhVien.lblTVChude.Text = "Đang Bán";
                    }
                }
            }
            else
            {
                    MessageBox.Show("Mặt hàng của bạn đăng bán thất bại");
            }

            // Thêm mặt hàng vào bảng HiểnThị
            string luotxem = "0";
            string yeuthich = "F";
            BanDo bando1 = new BanDo(txtBdTenMH.Text, maSanPham, luotxem, yeuthich);
            bds.ThemHienThi(bando1);
            
        }

        private void btnBdDangBan_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormDangBan(), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Đang Bán";
            }
            else
            {
                fd.OpenChildForm(new FormDangBan(), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Đang Bán";
            }
        }

        private void btnBdLammoi_Click_1(object sender, EventArgs e)
        {
            txtBdTenMH.Text = "";
            comboBdLoaiMH.Text = null;
            txtBdGiaban.Text = "";
            txtBdMota.Text = "";
            txtBdMa.Text = "Khong co";
            txtBdGiamgia.Text = "0";
            txtBdSlVou.Text = "0";
            txtBdMa.Enabled = false;
            txtBdGiamgia.Enabled = false;
            txtBdSlVou.Enabled = false;
            txtBdSoluong.Text = "";
            cbBoxTinhtrang.Text = null;
            txtImagePath.Text = "";
            txtBdDiadiem.Text = "";
            picImage.Image = null;
            if (rdBNguoibangiao.Checked)
                rdBNguoibangiao.Checked = false;
            else if (rdBChuyenPhatNhanh.Checked)
                rdBChuyenPhatNhanh.Checked = false;
            else
                rdBGiaohangtructiep.Checked = false;
            bds.Images = new List<Image>();
            bds.ImagePaths = new List<string>();
            bds.CurrentIndex = -1;
            txtDbGiaGoc.Text = "";
        }

        private void btnBdLuu_Click_1(object sender, EventArgs e)
        {
            string phuongthucGiaoHang = bds.ptGiaoHang(rdBChuyenPhatNhanh, rdBGiaohangtructiep, rdBNguoibangiao);
            string maSanPham = bds.RandomMaSanPham();
            BanDo banDo = new BanDo(txtBdTenMH.Text, comboBdLoaiMH.Text, txtBdGiaban.Text, txtBdMota.Text, bds.ImagePaths[0], bds.ImagePaths[1],
                 bds.ImagePaths[2], bds.ImagePaths[3], txtBdMa.Text, txtBdGiamgia.Text, txtBdSlVou.Text, txtBdSoluong.Text, txtBdDiadiem.Text, phuongthucGiaoHang, cbBoxTinhtrang.Text, maSanPham, dateTimeNgayban.Value.ToString(), DangKiDAO.ID, txtDbGiaGoc.Text);
             if (bds.SuaMatHang(banDo) == true)
             {
                 MessageBox.Show("Bạn đã sửa thông tin mặt hàng thành công");
                if (DangKiDAO.Chuc_vu == "Quan tri vien")
                {
                    fd.OpenChildForm(new FormDangBan(), FormTrangChu.panelTrangChu);
                    FormTrangChu.lblChude.Text = "Đang Bán";
                }
                else
                {
                    fd.OpenChildForm(new FormDangBan(), FormTrangChuThanhVien.panelTVTrangChu);
                    FormTrangChuThanhVien.lblTVChude.Text = "Đang Bán";
                }
            }
             else
             {
                 MessageBox.Show("Lỗi. Không sửa được");
             }
        }

        private void btnBdApdung_Click_1(object sender, EventArgs e)
        {
            txtBdMa.Enabled = true;
            txtBdGiamgia.Enabled = true;
            txtBdSlVou.Enabled = true;
            txtBdMa.Text = "";
            txtBdSlVou.Text = "";
            txtBdGiamgia.Text = "";
        }

        private void btnDbTruoc_Click_1(object sender, EventArgs e)
        {
            bds.ImageBefore(picImage, txtImagePath);
        }

        private void btnDbSau_Click_1(object sender, EventArgs e)
        {
            bds.ImageAfter(picImage, txtImagePath);
        }

        private void btnLoadImage_Click_1(object sender, EventArgs e)
        {
            bds.LoadImage(picImage, txtImagePath);
        }

        private void btnDbXoa_Click_1(object sender, EventArgs e)
        {
            bds.DeleteImage(picImage, txtImagePath);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}