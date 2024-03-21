using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormBanDo : Form
    {
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
            txtBdMa.Enabled = false;
            txtBdGiamgia.Enabled = false;
            txtBdSlVou.Enabled = false;
            OpenChildForm(new FormDangBan());
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Tạo một đối tượng Image từ tệp tin
                Image image = Image.FromFile(filePath);

                // Thiết lập kích thước ảnh phù hợp với PictureBox
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Image = image;
            }
        }

       
    }
}
