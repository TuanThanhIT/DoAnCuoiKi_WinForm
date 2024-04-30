using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class UCGioHang : UserControl
    {
        GioHangBUS ghb = new GioHangBUS();
        GioHang gh;
        string path;
        string ID;
        string check;
        string mavoucher;
        string giamgia;

        public UCGioHang()
        {
            InitializeComponent();
        }

        public UCGioHang(GioHang gh)
        {
            InitializeComponent();
            this.gh = gh;
            ID = gh.ID;
            UCGHlblTenMH.Text = gh.Ten_Mat_Hang;
            UCGHlblLoai.Text = gh.Loai_Mat_Hang;
            UCGHlblSoluong.Text = gh.So_Luong;
            UCGHlblNgay.Text = gh.Ngay_Dang_Ban;
            UCGHUpDown.Value = Convert.ToDecimal(gh.Soluongchon);
            UCGHlblGiacu.Text = gh.Gia_Goc;
            UCGHlblGiamoi.Text = gh.Gia_Ban;
            path = gh.Hinh_Anh_1;
            UCGHImagePicBox.Image = Image.FromFile(path);
            UCGHlblMa.Text = gh.Ma_San_Pham;
            check = gh.MaKiemTra;
            mavoucher = gh.Ma_Voucher;
            giamgia = gh.Giam_Gia;
        }

        private void UCGioHang_Load(object sender, EventArgs e)
        {
            UCGHlblGiacu.Font = new Font(UCGHlblGiacu.Font, FontStyle.Strikeout);
            UCGHUpDown_ValueChanged(sender, e);
            if (check == "T")
            {
                UCGHCheck.Checked = true;
            }




        }

        private void UCGHbtnXoa_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(UCGHlblMa.Text);
            if (ghb.XoaGioHang(gh))
            {
                MessageBox.Show("Xóa khỏi giỏi hàng thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xóa khỏi giỏi hàng thất bại");
            }

        }

        private void UCGHUpDown_ValueChanged(object sender, EventArgs e)
        {
            int quantity;
            double price;

            if (int.TryParse(UCGHUpDown.Value.ToString(), out quantity) && double.TryParse(UCGHlblGiamoi.Text, out price))
            {
                double thanhtoan = quantity * price;
                UCGHlblThanhtoan.Text = thanhtoan.ToString();
            }
            else
            {
                // Xử lý khi không thể chuyển đổi thành số
                UCGHlblThanhtoan.Text = "Thanh toán";
            }
        }

        private void UCGHCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UCGHCheck.Checked == true)
            {
                if (check == "F")
                    check = "T";
            }
            else
            {
                if (check == "T")
                    check = "F";
            }
        }


        private void UCGHbtnLuu_Click_1(object sender, EventArgs e)
        {
            if(UCGHUpDown.Value <= Convert.ToInt32(UCGHlblSoluong.Text))
            {
                GioHang gh = new GioHang(ID, UCGHlblTenMH.Text, UCGHlblLoai.Text, UCGHlblSoluong.Text, path, UCGHlblGiacu.Text, UCGHlblGiamoi.Text, UCGHUpDown.Value.ToString(), UCGHlblNgay.Text, UCGHlblMa.Text, check, mavoucher, giamgia);
                if (ghb.SuaGioHang(gh))
                {
                    MessageBox.Show("Bạn đã lưu những thay đổi");
                }
                else
                {
                    MessageBox.Show("Lỗi. Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Số lượng chọn của bạn vượt quá số lượng sản phẩm. Vui lòng chọn lại");
            }
            
        }
    }
}
