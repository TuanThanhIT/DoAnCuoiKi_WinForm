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
    public partial class FormReportMuaHang : Form
    {

        MuaHangBUS mhb = new MuaHangBUS();
        public FormReportMuaHang()
        {
            InitializeComponent();
        }

        private void FReportMuaHang_Load(object sender, EventArgs e)
        {
            List<MuaHang> listMuaHang = mhb.LoadMuaHang();
            List<MuaHangReport> listReport = new List<MuaHangReport>(); 
            foreach(MuaHang mh in listMuaHang)
            {
                MuaHangReport temp = new MuaHangReport();
                temp.ID = mh.ID;
                temp.Họ_tên_người_mua = mh.Hoten;
                temp.Số_điện_thoại = mh.Sodt;
                temp.Địa_chỉ = mh.Diachi;
                temp.Ngày_mua_hàng = mh.NgayMuaHang;
                temp.Mã_giao_dịch = mh.MaGiaoDich;
                temp.Tổng_thanh_toán = mh.TongThanhToan;

                listReport.Add(temp);
            }
            rptMuaHang.LocalReport.ReportPath = "ReportMuaHang.rdlc";
            var source = new ReportDataSource("MuaHangDataSet", listReport);
            rptMuaHang.LocalReport.DataSources.Clear();
            rptMuaHang.LocalReport.DataSources.Add(source);
            this.rptMuaHang.RefreshReport();
        }
    }
}
