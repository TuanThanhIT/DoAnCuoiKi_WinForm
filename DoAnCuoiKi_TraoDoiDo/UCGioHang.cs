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
        BanDoDao bdd = new BanDoDao();
        string path;
        string ID;
        string tenNguoiDung;
        
    
        public UCGioHang()
        {
            InitializeComponent();
        }

        public UCGioHang(BanDo bd)
        {
            InitializeComponent();
            ID = bd.ID;
            tenNguoiDung = bd.Ten_Nguoi_Dung;
            UCGHlblTenMH.Text = bd.Ten_Mat_Hang;
            UCGHlblLoai.Text = bd.Loai_Mat_Hang;
            UCGHlblSoluong.Text = bd.So_Luong;
            UCGHlblNgay.Text = bd.Ngay_Dang_Ban;
            UCGHUpDown.Value = Convert.ToDecimal(bd.So_Luong_Chon);
            UCGHlblGiacu.Text = bd.Gia_Goc;
            UCGHlblGiamoi.Text = bd.Gia_Ban;
            path = bd.Hinh_Anh_1;
            UCGHImagePicBox.Image = Image.FromFile(path);
            UCGHlblMa.Text = bd.Ma_San_Pham;
        }

        private void UCGioHang_Load(object sender, EventArgs e)
        {
            UCGHlblGiacu.Font = new Font(UCGHlblGiacu.Font, FontStyle.Strikeout);
            UCGHUpDown_ValueChanged(sender, e);
            
        }

        private void UCGHbtnXoa_Click(object sender, EventArgs e)
        {
            BanDo bd = new BanDo(ID, tenNguoiDung, UCGHlblTenMH.Text, UCGHlblLoai.Text, UCGHlblSoluong.Text, path, UCGHlblGiacu.Text, UCGHlblGiamoi.Text, UCGHUpDown.Value.ToString(), UCGHlblNgay.Text, UCGHlblMa.Text);
            bdd.XoaGH(bd);
            this.Hide();

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

       
    }
}
