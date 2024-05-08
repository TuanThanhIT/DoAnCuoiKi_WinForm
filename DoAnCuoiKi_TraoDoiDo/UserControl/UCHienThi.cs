using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;



namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCHienThi : UserControl
    {
        BanDo bando;
        FormBUS fd = new FormBUS();
        BanDoBUS bdb = new BanDoBUS();
        string maSanPham;
        string tenMathang;
        string yeuThich;
        int demLuotXem;
        public UCHienThi()
        {
            InitializeComponent();
        }


        public UCHienThi(BanDo bando)
        {
            InitializeComponent();
            this.bando = bando;
            tenMathang = bando.Tên_mặt_hàng;
            maSanPham = bando.Mã_sản_phẩm;
            UCHTlblTen.Text = tenMathang;
            UCHTlblGiaban.Text = bando.Giá_bán;
            string path = bando.Hình_ảnh_1;
            UCHTpicImage.Image = Image.FromFile(path);
            UCHTlblLuotxem.Text = bando.Lượt_xem;
            UCHTlblDiadiem.Text = bando.Địa_điểm;
            yeuThich = bando.Yêu_thích;
            demLuotXem = Convert.ToInt32(bando.Lượt_xem);
            UCHTlblGiagoc.Text = bando.Giá_gốc;
        }

        private void UCHienThi_Load(object sender, EventArgs e)
        {
            UCHTlblGiagoc.Font = new Font(UCHTlblGiagoc.Font, FontStyle.Strikeout);
            if (yeuThich == "T")
            {
                checkBoxYeuThich.Checked = true;
            }
            else
            {
                checkBoxYeuThich.Checked = false;
            }
        }


        private void UCHTbtnChitiet_Click(object sender, EventArgs e)
        {
            demLuotXem += 1;
            BanDo bd = new BanDo(tenMathang, maSanPham, demLuotXem.ToString(), yeuThich);
            bdb.SuaHienThi(bd);
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormChiTiet(bando), FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Chi Tiết Sản Phẩm";
            }
            else
            {
                fd.OpenChildForm(new FormChiTiet(bando), FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Chi Tiết sản phẩm";
            }
        }

        private void checkBoxYeuThich_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxYeuThich.Checked)
            {
                if(yeuThich == "F")
                {
                    yeuThich = "T";
                    BanDo bd = new BanDo(tenMathang, maSanPham, demLuotXem.ToString(), yeuThich);
                    bdb.SuaHienThi(bd);
                }
            }
            else
            {
                if(yeuThich == "T")
                {
                    yeuThich = "F";
                    BanDo bd = new BanDo(tenMathang, maSanPham, demLuotXem.ToString(), yeuThich);
                    bdb.SuaHienThi(bd);
                }
            }

           
        }
    }
}
