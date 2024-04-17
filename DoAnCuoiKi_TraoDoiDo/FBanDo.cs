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
    public partial class FormBanDo : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        BanDoDao bd = new BanDoDao();
        FormDao fd = new FormDao();
        public FormBanDo()
        {
            InitializeComponent();
            XuLyAnh.images = new List<Image>();
            XuLyAnh.imagePaths = new List<string>();
            XuLyAnh.currentIndex = -1;

        }


        string deliveryMethod = string.Empty;
        public string ptGiaoHang()
        {
            if (rdBChuyenPhatNhanh.Checked)
            {
                deliveryMethod = "Chuyen phat nhanh";
            }
            else if (rdBGiaohangtructiep.Checked)
            {
                deliveryMethod = "Giao hang truc tiep";
            }
            else if (rdBNguoibangiao.Checked)
            {
                deliveryMethod = "Nguoi ban tu giao";
            }
            return deliveryMethod;
        }
        public string chuyendoiAnh1()
        {
            string imagePath1 = XuLyAnh.imagePaths.Count > 0 ? XuLyAnh.imagePaths[0] : string.Empty;
            return imagePath1;
        }
        public string chuyendoiAnh2()
        {
            string imagePath2 = XuLyAnh.imagePaths.Count > 1 ? XuLyAnh.imagePaths[1] : string.Empty;
            return imagePath2;
        }
        public string chuyendoiAnh3()
        {
            string imagePath3 = XuLyAnh.imagePaths.Count > 2 ? XuLyAnh.imagePaths[2] : string.Empty;
            return imagePath3;
        }
        public string chuyendoiAnh4()
        {
            string imagePath4 = XuLyAnh.imagePaths.Count > 3 ? XuLyAnh.imagePaths[3] : string.Empty;
            return imagePath4;
        }
        public string RandomMaSanPham()
        {
            const int doDaiMaSanPham = 5;
            const string kyTuDung = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Tạo một HashSet để lưu trữ các mã sản phẩm đã được sử dụng
            HashSet<string> maSanPhamDaSuDung = new HashSet<string>();

            // Tạo một đối tượng Random
            Random random = new Random();

            // Tạo lặp cho đến khi tạo được mã sản phẩm mới
            while (true)
            {
                // Tạo một StringBuilder để xây dựng mã sản phẩm
                var stringBuilder = new System.Text.StringBuilder();

                // Tạo mã sản phẩm mới
                for (int i = 0; i < doDaiMaSanPham; i++)
                {
                    char kyTuNgauNhien = kyTuDung[random.Next(kyTuDung.Length)];
                    stringBuilder.Append(kyTuNgauNhien);
                }

                string maSanPhamMoi = stringBuilder.ToString();

                // Kiểm tra xem mã sản phẩm đã được sử dụng chưa
                if (!maSanPhamDaSuDung.Contains(maSanPhamMoi))
                {
                    maSanPhamDaSuDung.Add(maSanPhamMoi);
                    return maSanPhamMoi;
                }
            }
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    Image image = Image.FromFile(fileName);
                    XuLyAnh.images.Add(image);
                    XuLyAnh.imagePaths.Add(fileName);
                }

                if (XuLyAnh.images.Count > 0)
                {
                    XuLyAnh.currentIndex = 0;
                    picImage.SizeMode = PictureBoxSizeMode.Zoom;
                    picImage.Image = XuLyAnh.images[XuLyAnh.currentIndex];
                    txtImagePath.Text = XuLyAnh.imagePaths[XuLyAnh.currentIndex];
                }
            }
        }
        private void btnBdApdung_Click(object sender, EventArgs e)
        {
            txtBdMa.Enabled = true;
            txtBdGiamgia.Enabled = true;
            txtBdSlVou.Enabled = true;
        }



        private void FormBanDo_Load(object sender, EventArgs e)
        {
            if (XuLyAnh.images.Count > 0)
            {
                XuLyAnh.currentIndex = 0;
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Image = XuLyAnh.images[XuLyAnh.currentIndex];
                txtImagePath.Text = XuLyAnh.imagePaths[XuLyAnh.currentIndex];
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void btnDbXoa_Click_1(object sender, EventArgs e)
        {
            if (XuLyAnh.currentIndex >= 0 && XuLyAnh.currentIndex < XuLyAnh.images.Count)
            {
                XuLyAnh.images.RemoveAt(XuLyAnh.currentIndex);
                XuLyAnh.imagePaths.RemoveAt(XuLyAnh.currentIndex);

                if (XuLyAnh.images.Count > 0)
                {
                    XuLyAnh.currentIndex = Math.Min(XuLyAnh.currentIndex, XuLyAnh.images.Count - 1);
                    picImage.Image = XuLyAnh.images[XuLyAnh.currentIndex];
                    txtImagePath.Text = XuLyAnh.imagePaths[XuLyAnh.currentIndex];
                }
                else
                {
                    XuLyAnh.currentIndex = -1;
                    picImage.Image = null;
                    txtImagePath.Text = string.Empty;
                }
            }
        }

        private void btnDbTruoc_Click_1(object sender, EventArgs e)
        {
            if (XuLyAnh.images.Count > 0)
            {
                XuLyAnh.currentIndex = (XuLyAnh.currentIndex - 1 + XuLyAnh.images.Count) % XuLyAnh.images.Count;
                picImage.Image = XuLyAnh.images[XuLyAnh.currentIndex];
                txtImagePath.Text = XuLyAnh.imagePaths[XuLyAnh.currentIndex];
            }
        }

        private void btnDbSau_Click_1(object sender, EventArgs e)
        {

            if (XuLyAnh.images.Count > 0)
            {
                XuLyAnh.currentIndex = (XuLyAnh.currentIndex + 1) % XuLyAnh.images.Count;
                picImage.Image = XuLyAnh.images[XuLyAnh.currentIndex];
                txtImagePath.Text = XuLyAnh.imagePaths[XuLyAnh.currentIndex];
            }
        }

        private void btnBdHoantat_Click(object sender, EventArgs e)
        {
            BanDo bando = new BanDo(txtBdTenMH.Text, comboBdLoaiMH.Text, txtBdGiaban.Text, txtBdMota.Text, dateTimeNgayban.Value.ToString(), chuyendoiAnh1(), chuyendoiAnh2(), chuyendoiAnh3(), chuyendoiAnh4(),
                txtBdMa.Text, txtBdGiamgia.Text, txtBdSlVou.Text, txtBdSoluong.Text, txtBdDiadiem.Text, ptGiaoHang(), cbBoxTinhtrang.Text, RandomMaSanPham(), XuLyHienThi.ID, XuLyHienThi.Ten_Nguoi_Dung, txtDbGiaGoc.Text);
            bd.Them(bando);
            DialogResult result = MessageBox.Show("Bạn có tiếp tục muốn đăng bán mặt hàng khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                fd.OpenChildForm(new FormDangBan(), ref FormDao.activeForm, FormTrangChu.panelTrangChu);
                FormTrangChu.lblChude.Text = "Đăng bán";
            }
            else
            {
                XuLyAnh.images = new List<Image>();
                XuLyAnh.imagePaths = new List<string>();
                XuLyAnh.currentIndex = -1;
            }
        }

        private void btnBdLammoi_Click(object sender, EventArgs e)
        {
            txtBdTenMH.Text = "";
            comboBdLoaiMH.Text = null;
            txtBdGiaban.Text = "";
            txtBdMota.Text = "";
            txtBdMa.Text = "";
            txtBdGiamgia.Text = "";
            txtBdSlVou.Text = "";
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
            XuLyAnh.images = new List<Image>();
            XuLyAnh.imagePaths = new List<string>();
            XuLyAnh.currentIndex = -1;
            txtDbGiaGoc.Text = "";
        }

        private void btnBdLuu_Click(object sender, EventArgs e)
        {
            BanDo bando = new BanDo(txtBdTenMH.Text, comboBdLoaiMH.Text, txtBdGiaban.Text, txtBdMota.Text, dateTimeNgayban.Value.ToString(), chuyendoiAnh1(), chuyendoiAnh2(), chuyendoiAnh3(), chuyendoiAnh4(),
                txtBdMa.Text, txtBdGiamgia.Text, txtBdSlVou.Text, txtBdSoluong.Text, txtBdDiadiem.Text, ptGiaoHang(), cbBoxTinhtrang.Text, RandomMaSanPham(), XuLyHienThi.ID, XuLyHienThi.Ten_Nguoi_Dung, txtDbGiaGoc.Text);
            bd.Sua(bando);
        }

       

    }
}