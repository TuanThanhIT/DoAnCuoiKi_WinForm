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
        public FormChiTiet()
        {
            InitializeComponent();
        }
        FormTrangChu mainForm;
        string hinh1;
        string hinh2;
        string hinh3;
        string hinh4;
        public FormChiTiet(BanDo bando)
        {
            InitializeComponent();
            lblChitietMa.Text = bando.Ma_San_Pham;
            lblChitietTen.Text = bando.Ten_Mat_Hang;
            lblChitietLoaiMH.Text = bando.Loai_Mat_Hang;
            lblChitietGia.Text = bando.Gia_Ban;
            lblChitietMota.Text = bando.Mo_ta_mat_hang;
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
            lblChitietSlVou.Text = bando.So_Luong_Voucher;
            lblChitietSI.Text = bando.So_Luong;
            lblChitietDiadiem.Text = bando.Dia_Diem;
            lblCHitietTinhtrang.Text = bando.Tinh_Trang_Mat_Hang;
            lblChitietGiaohang.Text = bando.Phuong_Thuc_Giao_Hang;
        }
        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;
            if (mainForm != null)
            {
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.panelTrangChu.Controls.Clear();
                mainForm.panelTrangChu.Controls.Add(childForm);
                childForm.Show();
            }
        }
        private void btnThoat(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThemvao(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm vào giỏ hàng của bạn thành công");
        }
        private void btnMuangay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            this.Close();
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
           // LoadDataIntoChiTiet();
        }

        private void btnChitietThem_Click(object sender, EventArgs e)
        {
            BanDo bd = new BanDo(lblChitietMa.Text, lblChitietTen.Text, lblChitietLoaiMH.Text, lblChitietGia.Text, lblChitietMota.Text,
                hinh1, hinh2, hinh3, hinh4, lblChitietSI.Text, lblChitietSlVou.Text, lblChitietGiaohang.Text, lblCHitietTinhtrang.Text, lblChitietDiadiem.Text);
            bdd.ThemGioang(bd);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
