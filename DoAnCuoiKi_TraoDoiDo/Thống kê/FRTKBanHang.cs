using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class FormRTKBanHang : Form
    {
        BanDoBUS bdb = new BanDoBUS();  
        public FormRTKBanHang()
        {
            InitializeComponent();
        }

        private void FRTKBanHang_Load(object sender, EventArgs e)
        {
            string check = "T";
            List<BanHangReport> listReport = bdb.LoadDSBanHang(check);
            rpvBanHang.LocalReport.ReportPath = "ReportTKBanHang.rdlc";
            var source = new ReportDataSource("DataSetTKBanHang", listReport);
            rpvBanHang.LocalReport.DataSources.Clear();
            rpvBanHang.LocalReport.DataSources.Add(source);
            this.rpvBanHang.RefreshReport();
        }
    }
}
