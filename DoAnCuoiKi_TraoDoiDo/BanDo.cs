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

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormBanDo : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        FormDangBan f;
        public FormBanDo()
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
       
        private void btnBdHoantat_Click(object sender, EventArgs e)
        {
            try
            {
                string deliveryMethod = string.Empty;
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

                // Mở kết nối
                conn.Open();
                string sqlStr = string.Format("INSERT INTO ĐăngBán(Tên_mặt_hàng, Loại_mặt_hàng, Giá_bán, Mô_tả_mặt_hàng, Ngày_đăng_bán, Hình_ảnh, Mã_Voucher, Giảm_giá, Số_lượng_Voucher, Số_lượng, Địa_điểm, Phương_thức_giao_hàng, Tình_trạng_mặt_hàng) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", 
                txtBdTenMH.Text, comboBdLoaiMH.Text, txtBdGiaban.Text, txtBdMota.Text, dateTimeNgayban.Value.ToString(), convertImageToBytes(), txtBdMa.Text, txtBdGiamgia.Text,txtBdSlVou.Text, txtBdSoluong.Text, txtBdDiadiem.Text, deliveryMethod, cbBoxTinhtrang.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đăng bán thành công");
                    txtBdMa.Enabled = false;
                    txtBdGiamgia.Enabled = false;
                    txtBdSlVou.Enabled = false;
                    OpenChildForm(new FormDangBan());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng bán thất bại: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }


        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtImagePath.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void btnBdApdung_Click(object sender, EventArgs e)
        {
            txtBdMa.Enabled = true;
            txtBdGiamgia.Enabled = true;
            txtBdSlVou.Enabled = true;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                picImage.ImageLocation = imagePath;
                picImage.SizeMode = PictureBoxSizeMode.Zoom;

                txtImagePath.Text = imagePath;
            }

        }



    }
}
