using DoAnCuoiKi_TraoDoiDo.BUS;
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
    public partial class FormNoiThat : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormNoiThat()
        {
            InitializeComponent();
        }
        string loaimathang = "Noi that";
        private void FormNoiThat_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPNoithat);
        }
    }
}
