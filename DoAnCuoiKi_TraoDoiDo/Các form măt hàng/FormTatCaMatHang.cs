using DoAnCuoiKi_TraoDoiDo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormTatCaMatHang : Form
    {

        BanDoBUS bdb = new BanDoBUS();
        public FormTatCaMatHang()
        {
            InitializeComponent();

        }
        string loaimathang = "All";
        private void FormTatCaMatHang_Load(object sender, EventArgs e)
        {
            bdb.LoadDanhSach(loaimathang, flowLPHienthiAll);


        }



    }

}
