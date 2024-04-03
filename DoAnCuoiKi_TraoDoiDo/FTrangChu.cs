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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public FormTrangChu(DangKi dk)
        {
            InitializeComponent();
            dk.Tendangnhap = lblTrangchuTen.Text;
            dk.Chucvu = lblTrangChuChucvu.Text;
            dk.ID = lblTrangChuID.Text;
        }
        private Form currentFormChild;

        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTrangChu.Controls.Add(childForm);
            panelTrangChu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormTrangChu_Load_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain());
            lblChude.Text = "Trang Chủ";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain());
            lblChude.Text = "Trang Chủ";
        }

        private void btnBanDo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanDo());
            lblChude.Text = "Bán Hàng";
        }

        private void btnMatHang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormMatHang());
            lblChude.Text = "Mặt Hàng";
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
            lblChude.Text = "Thống Kê";
        }

        private void btnLichsu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xem: Chọn Yes để xem lịch sử bán, No để xem lịch sử mua, hoặc Cancel để thoát", "Thông Báo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormLsBanHang());
                lblChude.Text = "Lịch Sử";
            }
            else if (result == DialogResult.No)
            {
                OpenChildForm(new FormLSMuaHang());
                lblChude.Text = "Lịch Sử";
            }
        }

        private void btnMylichsu_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xem: Chọn Yes để xem lịch sử bán hàng của bạn, No để xem lịch sử mua hàng của bạn, hoặc Cancel để thoát", "Thông Báo",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new FormLsBanHang());
                lblChude.Text = "Lịch sử của tôi";
            }
            else if (result == DialogResult.No)
            {
                OpenChildForm(new FormLSMuaHang());
                lblChude.Text = "Lịch sử của tôi";
            }
        }

        private void btnGioHang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormGioHang());
            lblChude.Text = "Giỏ hàng";
        }

        private void dateTimePickerTrangchu_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTrangchu.Value = DateTime.Now;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
