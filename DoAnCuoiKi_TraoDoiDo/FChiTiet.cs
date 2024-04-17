using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormChiTiet : Form
    {
  
        BanDoDao bdd = new BanDoDao();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        BanDo bando;
        FormDao fd = new FormDao();
        GioHangDao ghd = new GioHangDao();

        public FormChiTiet()
        {
            InitializeComponent();
        }
        string hinh1;
        string hinh2;
        string hinh3;
        string hinh4;
        public FormChiTiet(BanDo bando)
        {
            this.bando = bando;
            InitializeComponent();
            txtChiTietMa.Text = bando.Ma_San_Pham;
            lblChitietTen.Text = bando.Ten_Mat_Hang;
            txtChiTietLoai.Text = bando.Loai_Mat_Hang;
            lblChiTietGiaban.Text = bando.Gia_Ban;
            txtChitietMota.Text = bando.Mo_ta_mat_hang;
            List<string> imagePathList = new List<string>();
            hinh1 = bando.Hinh_Anh_1;
            hinh2 = bando.Hinh_Anh_2;
            hinh3 = bando.Hinh_Anh_3;
            hinh4 = bando.Hinh_Anh_4;
            imagePathList.Add(hinh1);
            imagePathList.Add(hinh2);
            imagePathList.Add(hinh3);
            imagePathList.Add(hinh4);
            // Khởi tạo biến đếm và gán giá trị ban đầu là 0
            int currentImageIndex = 0;

            // Khởi tạo Timer với khoảng thời gian là 5 giây (5000 milliseconds)
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;

            // Hiển thị ảnh đầu tiên trong UCChiTietPicBox
            DisplayImageAtIndex(currentImageIndex);

            // Bắt đầu chuyển đổi tự động sau khi khởi động ứng dụng
            timer.Start();

            // Hàm để hiển thị ảnh tại chỉ số index trong danh sách
            void DisplayImageAtIndex(int index)
            {
                // Kiểm tra xem chỉ số có hợp lệ hay không
                if (index >= 0 && index < imagePathList.Count)
                {
                    // Kiểm tra xem đường dẫn hình ảnh có tồn tại hay không
                    if (File.Exists(imagePathList[index]))
                    {
                        // Đọc và hiển thị ảnh từ đường dẫn
                        Image image = Image.FromFile(imagePathList[index]);
                        picImageChitiet.Image = image;
                    }
                }
            }

            // Xử lý sự kiện của Timer
            void Timer_Tick(object sender, EventArgs e)
            {
                // Tăng giá trị của biến đếm
                currentImageIndex++;
                // Kiểm tra xem có vượt quá số lượng ảnh hay không
                if (currentImageIndex >= imagePathList.Count)
                {
                    // Quay lại ảnh đầu tiên
                    currentImageIndex = 0;
                }
                // Hiển thị ảnh tại chỉ số hiện tại
                DisplayImageAtIndex(currentImageIndex);
            }
            txtChiTietSLVou.Text = bando.So_Luong_Voucher;
            lblChotietSoluong.Text = bando.So_Luong;
            txtChiTietDiaDiem.Text = bando.Dia_Diem;
            txtChitietTinhtrang.Text = bando.Tinh_Trang_Mat_Hang;
            txtChiTietGiaohang.Text = bando.Phuong_Thuc_Giao_Hang;
            lblChitietGiacu.Text = bando.Gia_Goc;
            lblChiTietGiamgia.Text = bando.Giam_Gia;
            txtChitietNgay.Text = bando.Ngay_Dang_Ban;
        }

        private void btnChitietMua_Click(object sender, EventArgs e)
        {
            FormThanhToan f = new FormThanhToan(bando);
            f.Show();
            this.Hide();
            
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            lblChitietGiacu.Font = new Font(lblChitietGiacu.Font, FontStyle.Strikeout);
            lblChitietRateStar.Font = new Font(lblChitietRateStar.Font, FontStyle.Underline);
        }


        private void btnChiTietThoat_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormMatHang(), ref FormDao.activeForm, FormTrangChu.panelTrangChu);
        }

        private void btnChitietThem_Click(object sender, EventArgs e)
        {
            string check = "F"; 
            GioHang gh = new GioHang(XuLyHienThi.ID, XuLyHienThi.Ten_Nguoi_Dung, lblChitietTen.Text, txtChiTietLoai.Text, lblChotietSoluong.Text, hinh1, lblChitietGiacu.Text, lblChiTietGiaban.Text,
                NumUpDown.Value.ToString(), txtChitietNgay.Text, txtChiTietMa.Text, check); ;
            ghd.ThemGioHang(gh);
        }

        private void btnChiTietMuangay_Click(object sender, EventArgs e)
        {
            string check = "T"; ;
            GioHang gh = new GioHang(XuLyHienThi.ID, XuLyHienThi.Ten_Nguoi_Dung, lblChitietTen.Text, txtChiTietLoai.Text, lblChotietSoluong.Text, hinh1, lblChitietGiacu.Text, lblChiTietGiaban.Text,
                NumUpDown.Value.ToString(), txtChitietNgay.Text, txtChiTietMa.Text, check); ;
            ghd.ThemGioHang(gh);
            this.Hide();
            fd.OpenChildForm(new FormGioHang(), ref FormDao.activeForm, FormTrangChu.panelTrangChu); 
            
        }
    }
}
