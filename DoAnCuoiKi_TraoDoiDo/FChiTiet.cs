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
using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormChiTiet : Form
    {
        BanDo bando;
        FormDAO fd = new FormDAO();
        GioHangBUS ghb = new GioHangBUS();
         DanhGiaBUS dgb = new DanhGiaBUS();
        string hinh1;
        string hinh2;
        string hinh3;
        string hinh4;
        string maVoucher;
        string giamGia;
        public FormChiTiet()
        {
            InitializeComponent();
        }

        public FormChiTiet(BanDo bando)
        {
            this.bando = bando;
            InitializeComponent();
            txtChiTietMa.Text = bando.Mã_sản_phẩm;
            lblChitietTen.Text = bando.Tên_mặt_hàng;
            txtChiTietLoai.Text = bando.Loại_mặt_hàng;
            lblChiTietGiaban.Text = bando.Giá_bán;
            txtChitietMota.Text = bando.Mô_tả_mặt_hàng;
            List<string> imagePathList = new List<string>();
            hinh1 = bando.Hình_ảnh_1;
            hinh2 = bando.Hình_ảnh_2;
            hinh3 = bando.Hình_ảnh_3;
            hinh4 = bando.Hình_ảnh_4;
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
            txtChiTietSLVou.Text = bando.Số_lượng_Voucher;
            lblChotietSoluong.Text = bando.Số_lượng;
            txtChiTietDiaDiem.Text = bando.Địa_điểm;
            txtChitietTinhtrang.Text = bando.Tình_trạng_mặt_hàng;
            txtChiTietGiaohang.Text = bando.Phương_thức_giao_hàng;
            lblChitietGiacu.Text = bando.Giá_gốc;
            lblChiTietGiamgia.Text = bando.Giảm_giá;
            txtChitietNgay.Text = bando.Ngày_đăng_bán;
            maVoucher = bando.Mã_Voucher;
            giamGia = bando.Giảm_giá;
        }


        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            lblChitietGiacu.Font = new Font(lblChitietGiacu.Font, FontStyle.Strikeout);
            lblChitietRateStar.Font = new Font(lblChitietRateStar.Font, FontStyle.Underline);
            dgb.LoadDanhGia(flowLPDanhGia, bando.Mã_sản_phẩm);
        }




        private void btnChitietThem_Click_1(object sender, EventArgs e)
        {
            if(NumUpDown.Value <= Convert.ToInt32(lblChotietSoluong.Text))
            {
                string check = "F";
                GioHang gh = new GioHang(DangKiDAO.ID, lblChitietTen.Text, txtChiTietLoai.Text, lblChotietSoluong.Text, hinh1, lblChitietGiacu.Text, lblChiTietGiaban.Text,
                     NumUpDown.Value.ToString(), txtChitietNgay.Text, txtChiTietMa.Text, check, maVoucher, giamGia);
                if (ghb.ThemGioHang(gh) == true)
                {
                    MessageBox.Show("Thêm vào giỏ hàng của bạn thành công");
                }
                else
                {
                    MessageBox.Show("Thêm vào giỏ hàng của bạn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Số lượng chọn của bạn vượt quá số lượng sản phẩm. Vui lòng chọn lại");
            }
            
        }

        private void btnChiTietMuangay_Click_1(object sender, EventArgs e)
        {
            if (NumUpDown.Value <= Convert.ToInt32(lblChotietSoluong.Text))
            {
                string check = "T"; ;
                GioHang gh = new GioHang(DangKiDAO.ID, lblChitietTen.Text, txtChiTietLoai.Text, lblChotietSoluong.Text, hinh1, lblChitietGiacu.Text, lblChiTietGiaban.Text,
                    NumUpDown.Value.ToString(), txtChitietNgay.Text, txtChiTietMa.Text, check, maVoucher, giamGia);
                if (ghb.ThemGioHang(gh))
                {
                    if (DangKiDAO.Chuc_vu == "Quan tri vien")
                    {
                        fd.OpenChildForm(new FormGioHang(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                        FormTrangChu.lblChude.Text = "Giỏ Hàng";
                    }
                    else
                    {
                        fd.OpenChildForm(new FormGioHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                        FormTrangChuThanhVien.lblTVChude.Text = "Giỏ Hàng";
                    }
                }
            }
            else
            {
                MessageBox.Show("Số lượng chọn của bạn vượt quá số lượng sản phẩm. Vui lòng chọn lại");
            }
            
        }

        private void btnChiTietDanhgia_Click(object sender, EventArgs e)
        {
            FormDanhGia f = new FormDanhGia(bando);
            f.Show();
        }


        private void btnChiTietThoat_Click_1(object sender, EventArgs e)
        {
            if (DangKiDAO.Chuc_vu == "Quan tri vien")
            {
                fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Mặt Hàng";
            }
            else
            {
                fd.OpenChildForm(new FormMatHang(), ref FormDAO.activeForm, FormTrangChuThanhVien.panelTVTrangChu);
                FormTrangChuThanhVien.lblTVChude.Text = "Mặt Hàng";
            }

        }
    }
}
