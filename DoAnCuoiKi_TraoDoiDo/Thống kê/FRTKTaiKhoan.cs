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
    public partial class FormRTKTaiKhoan : Form
    {
        DangKiBUS dkb = new DangKiBUS();
        public FormRTKTaiKhoan()
        {
            InitializeComponent();
        }

        private void FRTKTaiKhoan_Load(object sender, EventArgs e)
        {
            List<TaiKhoanReport> listReport = dkb.layDuLieu();

            rpvTKTaiKhoan.LocalReport.ReportPath = "ReportTKTaiKhoan.rdlc";
            var source = new ReportDataSource("DataSetTaiKhoan", listReport);
            rpvTKTaiKhoan.LocalReport.DataSources.Clear();
            rpvTKTaiKhoan.LocalReport.DataSources.Add(source);
            this.rpvTKTaiKhoan.RefreshReport();
        }
    }
}
