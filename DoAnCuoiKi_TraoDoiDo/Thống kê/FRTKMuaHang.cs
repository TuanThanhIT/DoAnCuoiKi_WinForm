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
    public partial class FormRTKMuaHang : Form
    {
        MuaHangBUS mhb = new MuaHangBUS();
        public FormRTKMuaHang()
        {
            InitializeComponent();
        }

        private void FRTKMuaHang_Load(object sender, EventArgs e)
        {
            List<MuaHangReport> listReport = mhb.LayDuLieu();

            rpVTKMuaHang.LocalReport.ReportPath = "ReportTKMuaHang.rdlc";
            var source = new ReportDataSource("DataSetTKMuaHang", listReport);
            rpVTKMuaHang.LocalReport.DataSources.Clear();
            rpVTKMuaHang.LocalReport.DataSources.Add(source);
            this.rpVTKMuaHang.RefreshReport();
        }
    }
}
