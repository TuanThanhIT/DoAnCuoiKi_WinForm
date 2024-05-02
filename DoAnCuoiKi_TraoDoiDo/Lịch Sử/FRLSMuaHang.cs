using DoAnCuoiKi_TraoDoiDo.BUS;
using DoAnCuoiKi_TraoDoiDo.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormRLSMuaHang : Form
    {
        MuaHangBUS mhb = new MuaHangBUS();
        public FormRLSMuaHang()
        {
            InitializeComponent();
        }

        private void FormRLSMuaHang_Load(object sender, EventArgs e)
        {
            List<MuaHangReport> listReport = mhb.LayDuLieu();

            rptMuaHang.LocalReport.ReportPath = "ReportMuaHang.rdlc";
            var source = new ReportDataSource("MuaHangDataSet", listReport);
            rptMuaHang.LocalReport.DataSources.Clear();
            rptMuaHang.LocalReport.DataSources.Add(source);
            this.rptMuaHang.RefreshReport();
        }
    }
}
