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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        BanDoDao bdd = new BanDoDao();
        FormBanDo f = new FormBanDo();
        XuLyAnh xuLyAnh = new XuLyAnh();
        XuLyGiaoDien xlgiaodien = new XuLyGiaoDien();
        List<Image> images = new List<Image>();
        List<string> imagePaths = new List<string>();
        private FormTatCaMatHang formAll;
        public FormDangBan()
        {
            InitializeComponent();;
        }
        FormTrangChu mainForm;
        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;
            xlgiaodien.OpenChildForm(mainForm,childForm);
        }
        private void FormDangBan_Load(object sender, EventArgs e)
        {
            DataTable a = bdd.Load();
            gvDangban.DataSource = a;
        }

        private void btnDbQuaylai_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormBanDo());
        }

        
        private void btnDbChinhsua_Click(object sender, EventArgs e)
        {
            xuLyAnh.Images = images;
            xuLyAnh.ImagePaths = imagePaths;
            xuLyAnh.HienThiAnh(f.picImage, f.txtImagePath);
            OpenChildForm(f);
            
        }

       

        private void btnDbXoa_Click(object sender, EventArgs e)
        {
            BanDo bando = new BanDo(f.txtBdTenMH.Text, f.comboBdLoaiMH.Text, float.TryParse(f.txtBdGiaban.Text, out float giaban) ? giaban : 0, f.txtBdMota.Text, f.dateTimeNgayban.Value, f.chuyendoiAnh1(), f.chuyendoiAnh2(), f.chuyendoiAnh3(), f.chuyendoiAnh4(),
                f.txtBdMa.Text, float.TryParse(f.txtBdGiamgia.Text, out float giamgia) ? giamgia : 0, int.TryParse(f.txtBdSlVou.Text, out int slVou) ? slVou : 0,
                int.TryParse(f.txtBdSoluong.Text, out int soluong) ? soluong : 0, f.txtBdDiadiem.Text, f.ptGiaoHang(), f.cbBoxTinhtrang.Text);
            bdd.Xoa(bando);
            FormDangBan_Load(sender, e);
        }

        private void gvDangban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvDangban.Rows[e.RowIndex];

                f.txtBdTenMH.Text = row.Cells["Tên_mặt_hàng"].Value.ToString();
                f.comboBdLoaiMH.Text = row.Cells["Loại_mặt_hàng"].Value.ToString();
                f.txtBdGiaban.Text = row.Cells["Giá_bán"].Value.ToString();
                f.txtBdMota.Text = row.Cells["Mô_tả_mặt_hàng"].Value.ToString();
                string ngayDangBanStr = row.Cells["Ngày_đăng_bán"].Value.ToString();
                DateTime ngayDangBan;
                if (DateTime.TryParse(ngayDangBanStr, out ngayDangBan))
                {
                    f.dateTimeNgayban.Value = ngayDangBan;
                }
                else
                {
                    f.dateTimeNgayban.Value = DateTime.Now;
                }

                // Lưu đường dẫn vào ImagePaths
                string imagePath1 = row.Cells["Hình_ảnh_1"].Value.ToString();
                string imagePath2 = row.Cells["Hình_ảnh_2"].Value.ToString();
                string imagePath3 = row.Cells["Hình_ảnh_3"].Value.ToString();
                string imagePath4 = row.Cells["Hình_ảnh_4"].Value.ToString();
                imagePaths.Add(imagePath1);
                imagePaths.Add(imagePath2);
                imagePaths.Add(imagePath3);
                imagePaths.Add(imagePath4);
              
                    // Tạo đối tượng Image từ từng đường dẫn và lưu vào Images
                foreach (string imagePath in imagePaths)
                {
                    Image image = Image.FromFile(imagePath);
                    images.Add(image);
                }
             
                f.txtBdMa.Text = row.Cells["Mã_Voucher"].Value.ToString();
                f.txtBdGiamgia.Text = row.Cells["Giảm_giá"].Value.ToString();
                f.txtBdSlVou.Text = row.Cells["Số_lượng_Voucher"].Value.ToString();
                f.txtBdSoluong.Text = row.Cells["Số_lượng"].Value.ToString();
                f.txtBdDiadiem.Text = row.Cells["Địa_điểm"].Value.ToString();
                if (row.Cells["Phương_thức_giao_hàng"].Value.ToString() == "Chuyen phat nhanh")
                {
                    f.rdBChuyenPhatNhanh.Checked = true;
                }
                else if (row.Cells["Phương_thức_giao_hàng"].Value.ToString() == "Giao hang boi nguoi ban")
                {
                    f.rdBNguoibangiao.Checked = true;
                }
                else
                {
                    f.rdBGiaohangtructiep.Checked = true;
                }
                f.cbBoxTinhtrang.Text = row.Cells["Tình_trạng_mặt_hàng"].Value.ToString();
            }
        }
        public void HienThiTatCaMatHang()
        {
            FormTatCaMatHang formAll = new FormTatCaMatHang();
            // Lặp qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in gvDangban.Rows)
            {
                // Kiểm tra điều kiện cột "Số_lượng" khác 0
                int soLuong = Convert.ToInt32(row.Cells["Số_lượng"].Value);
                if (soLuong != 0)
                {
                    // Tạo UserControl
                    UCHienThi ucHienThi = new UCHienThi();

                    // Đặt giá trị cho label và pictureBox trong UserControl
                    ucHienThi.UCHTlblGia.Text = row.Cells["Giá_tiền"].Value.ToString();
                    string imagePath = row.Cells["Hình_ảnh_1"].Value.ToString();
                    ucHienThi.UCHTPictureBox.Image = Image.FromFile(imagePath);

                    // Thêm UserControl vào FormTatCaMatHang
                    formAll.Controls.Add(ucHienThi);
                }
            }
        }
    }
}
