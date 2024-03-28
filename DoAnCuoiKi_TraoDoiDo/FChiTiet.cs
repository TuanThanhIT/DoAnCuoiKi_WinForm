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
    public partial class FormChiTiet : Form
    {
        public FormChiTiet()
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
        private void ucChiTiet1_Load(object sender, EventArgs e)
        {
            ucChiTiet1.UCChitietbtnThoat.Click += btnThoat;
            ucChiTiet1.UCChiTietbtnThem.Click += btnThemvao;
            ucChiTiet1.UCChiTietbtnMua.Click += btnMuangay_Click;
        }

    }
}
