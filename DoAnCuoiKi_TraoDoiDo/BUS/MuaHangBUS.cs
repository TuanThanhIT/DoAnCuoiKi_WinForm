using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class MuaHangBUS
    {
        MuaHangDAO mhd = new MuaHangDAO();
        BUS bus = new BUS();
        public bool ThemMuaHang(MuaHang mh)
        {
            return mhd.ThemMuaHang(mh);
        }
        public string RanDomMaGiaoDich()
        {
            return bus.RandomMa(6);
        }
        public DataTable DSMuaHang()  // Lịch Sử Mua Hàng
        {
            return mhd.DSMuaHang();
        }
        public DataTable TKMuaHang()
        {
            return mhd.TKMuaHang(); 
        }
        public bool XoaLSMuaHang()
        {
            return mhd.xoaLSMuaHang();
        }
        public List<MuaHang> LoadMuaHang() // Báo cáo lịch sử mua hàng, lấy dữ liệu lên
        {
            return mhd.LoadMuaHang();
        }
        public List<MuaHang> LoadTKMuaHang()  // Báo cáo thống kê mua hàng
        {
            return mhd.LoadTKMuaHang();
        }
        public List<MuaHangReport> LayDuLieu()  // Báo cáo lịch sử mua hàng, đưa dữ liệu vào list
        {
            List<MuaHang> listMuaHang = LoadMuaHang();
            List<MuaHangReport> listReport = new List<MuaHangReport>();
            foreach (MuaHang mh in listMuaHang)
            {
                MuaHangReport temp = new MuaHangReport();
                temp.ID = mh.ID;
                temp.Họ_tên = mh.Họ_tên;
                temp.Số_điện_thoại = mh.Số_điện_thoại;
                temp.Địa_chỉ = mh.Địa_chỉ;
                temp.Ngày_mua_hàng = mh.Ngày_mua_hàng;
                temp.Mã_giao_dịch = mh.Mã_giao_dịch;
                temp.Tổng_thanh_toán = mh.Tổng_thanh_toán;

                listReport.Add(temp);
            }
            return listReport;
        }
    }
}
