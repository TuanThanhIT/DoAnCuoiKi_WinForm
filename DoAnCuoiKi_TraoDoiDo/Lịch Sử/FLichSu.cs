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
    public partial class FormLichSu : Form
    {
        FormBUS fd = new FormBUS(); 
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLSMuaHang(), panelLichSu);
        }
        

        private void btnLSMuaHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLSMuaHang(), panelLichSu);
        }

        private void btnLSBanHang_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new FormLSBanHang(), panelLichSu);
        }
    }
}
