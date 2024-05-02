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
using System.Web.UI;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormRLSBanHang : Form
    {
        BanDoBUS bdb = new BanDoBUS();
        public FormRLSBanHang()
        {
            InitializeComponent();
        }

        private void FormRLSBanHang_Load(object sender, EventArgs e)
        {
            string check = "F";
            List<BanHangReport> listReport = bdb.LoadDSBanHang(check);
            rptBanHang.LocalReport.ReportPath = "ReportBanHang.rdlc";
            var source = new ReportDataSource("DataSetBanHang", listReport);
            rptBanHang.LocalReport.DataSources.Clear();
            rptBanHang.LocalReport.DataSources.Add(source);
            this.rptBanHang.RefreshReport();
        }
    }
}
