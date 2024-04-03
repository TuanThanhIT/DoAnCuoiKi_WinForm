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
    public partial class FormGioHang : Form
    {
        BanDoDao bdd = new BanDoDao();
        string hinh1;
        string hinh2;
        string hinh3;
        string hinh4;
        public FormGioHang()
        {
            InitializeComponent();
        }
        FormTrangChu mainForm;
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
        private void btnGHQuayLai_Click(object sender, EventArgs e)
        {
            mainForm = this.ParentForm as FormTrangChu;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormMain());
                mainForm.lblChude.Text = "Trang Chủ";

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan());
            mainForm.lblChude.Text = "Thanh Toán";
        }

        private void ucGioHang1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void FormGioHang_Load(object sender, EventArgs e)
        {
            DataTable a = bdd.Load2();
            gvGioHang.DataSource = a;   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private List<string> imagePathList;
        private void gvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvGioHang.Rows[e.RowIndex];

                lblGhTen.Text = row.Cells["Tên_mặt_hàng"].Value.ToString();
                lblGhLoai.Text = row.Cells["Loại_mặt_hàng"].Value.ToString();
                lblGHGiaban.Text = row.Cells["Giá_bán"].Value.ToString();
                lblGhMota.Text = row.Cells["Mô_tả_mặt_hàng"].Value.ToString();
                lblGhSl.Text = row.Cells["Số_lượng"].Value.ToString();
                lblGHSlVou.Text = row.Cells["Số_lượng_Vou"].Value.ToString();
                lblGHDiadiem.Text = row.Cells["Địa_điểm"].Value.ToString();
                lblGhGiaohang.Text = row.Cells["Phương_thức_giao_hàng"].Value.ToString();
                lblGHtinhtrang.Text = row.Cells["Tình_trạng_mặt_hàng"].Value.ToString();
                lblGHMa.Text = row.Cells["Mã_mặt_hàng"].Value.ToString();

                imagePathList = new List<string>();
                hinh1 = row.Cells["Hình_ảnh_1"].Value.ToString();
                hinh2 = row.Cells["Hình_ảnh_2"].Value.ToString();
                hinh3 = row.Cells["Hình_ảnh_3"].Value.ToString();
                hinh4 = row.Cells["Hình_ảnh_4"].Value.ToString();
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
                            picImageGH.Image = image;
                        }
                    }
                }

                // Xử lý sự kiện của Timer
                void Timer_Tick(object eventSender, EventArgs eventArgs)
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
            

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             BanDo bd = new BanDo(lblGHMa.Text,lblGhTen.Text, lblGhLoai.Text, lblGHGiaban.Text, lblGhMota.Text, hinh1, hinh2, hinh3, hinh4, lblGhSl.Text, lblGHSlVou.Text, lblGhGiaohang.Text, lblGHtinhtrang.Text, lblGHDiadiem.Text);
             bdd.XoaGH(bd);
             lblGHMa.Text = "";
             lblGhTen.Text = "";
             lblGhLoai.Text = "";
             lblGHGiaban.Text = "";
             lblGhMota.Text = "";
            picImageGH.Image = null;
            imagePathList.Clear();

            lblGhSl.Text = "";
            lblGHSlVou.Text = "";
            lblGhGiaohang.Text = "";
            lblGHtinhtrang.Text = ""; 
            lblGHDiadiem.Text= "";
            FormGioHang_Load(sender, e);
        }
    }
}
