using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormBanDo : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        BanDoDao bd = new BanDoDao();
        FormTrangChu mainForm;
        XuLyAnh xulyanh = new XuLyAnh();
        XuLyGiaoDien xlgiaodien = new XuLyGiaoDien();
        public FormBanDo()
        {
            InitializeComponent();
            xulyanh.Rong();
        }


        public void OpenChildForm(Form childForm)
        {
            mainForm = this.ParentForm as FormTrangChu;
            xlgiaodien.OpenChildForm(mainForm, childForm);
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
            string imagePath1 = xulyanh.ImagePaths.Count > 0 ? xulyanh.ImagePaths[0] : string.Empty;
            return imagePath1;
        }
        public string chuyendoiAnh2()
        {
            string imagePath2 = xulyanh.ImagePaths.Count > 1 ? xulyanh.ImagePaths[1] : string.Empty;
            return imagePath2;
        }
        public string chuyendoiAnh3()
        {
            string imagePath3 = xulyanh.ImagePaths.Count > 2 ? xulyanh.ImagePaths[2] : string.Empty;
            return imagePath3;
        }
        public string chuyendoiAnh4()
        {
            string imagePath4 = xulyanh.ImagePaths.Count > 3 ? xulyanh.ImagePaths[3] : string.Empty;
            return imagePath4;
        }
        private void btnBdHoantat_Click(object sender, EventArgs e)
        {
            BanDo bando = new BanDo(txtBdTenMH.Text, comboBdLoaiMH.Text, float.TryParse(txtBdGiaban.Text, out float giaban) ? giaban : 0, txtBdMota.Text,dateTimeNgayban.Value, chuyendoiAnh1(), chuyendoiAnh2(), chuyendoiAnh3(), chuyendoiAnh4(),
                txtBdMa.Text, float.TryParse(txtBdGiamgia.Text, out float giamgia) ? giamgia : 0, int.TryParse(txtBdSlVou.Text, out int slVou) ? slVou : 0,
                int.TryParse(txtBdSoluong.Text, out int soluong) ? soluong : 0, txtBdDiadiem.Text, ptGiaoHang(), cbBoxTinhtrang.Text);
            bd.Them(bando);
            DialogResult result = MessageBox.Show("Bạn có tiếp tục muốn đăng bán mặt hàng khác", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                OpenChildForm(new FormDangBan());
            }
            
            xulyanh.Rong();
        }

        public void btnLoadImage_Click(object sender, EventArgs e)
        {
            xulyanh.ImageLoad(picImage, txtImagePath);
        }
        public void btnDbTruoc_Click(object sender, EventArgs e)
        {
            xulyanh.Before(picImage, txtImagePath);
        }

        public void btnDbSau_Click(object sender, EventArgs e)
        {
           xulyanh.After(picImage, txtImagePath);
        }

        private void btnBdApdung_Click(object sender, EventArgs e)
        {
            txtBdMa.Enabled = true;
            txtBdGiamgia.Enabled = true;
            txtBdSlVou.Enabled = true;
        }

        private void btnBdLammoi_Click(object sender, EventArgs e)
        {
            txtBdTenMH.Text = "";
            comboBdLoaiMH.Text = "";
            txtBdGiaban.Text = "";
            txtBdMota.Text = "";
            txtBdMa.Text = "";
            txtBdGiamgia.Text = "";
            txtBdSlVou.Text = "";
            txtBdSoluong.Text = "";
            cbBoxTinhtrang.Text = "";    
            txtImagePath.Text = "";
            picImage.Image = null;  
            if (rdBNguoibangiao.Checked)
                rdBNguoibangiao.Checked = false;
            else if (rdBChuyenPhatNhanh.Checked)
                rdBChuyenPhatNhanh.Checked = false;
            else
                rdBGiaohangtructiep.Checked = false;
            xulyanh.Rong();
        }

        private void btnDbXoa_Click(object sender, EventArgs e)
        {
            xulyanh.XoaAnhHienTai(picImage, txtImagePath);
        }

        private void FormBanDo_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}