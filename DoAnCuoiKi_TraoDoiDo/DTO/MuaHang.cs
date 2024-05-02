using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class MuaHang : DangKi
    {
        private string ngayMuaHang;
        private string tongThanhToan;
        private string maGiaoDich;
        public string Ngày_mua_hàng
        {
            get { return ngayMuaHang; }
            set { ngayMuaHang = value; }
        }
        public string Tổng_thanh_toán
        {
            get { return tongThanhToan; }
            set { tongThanhToan = value; }
        }
        public string Mã_giao_dịch
        {
            get { return maGiaoDich; }
            set { maGiaoDich = value; }
        }
        public MuaHang()
        {

        }
        public MuaHang(string soDt, string diaChi, string ngayMuaHang, string iD, string tongThanhToan, string maGiaoDich, string hoTen)
        {
            Họ_tên = hoTen;
            Số_điện_thoại = soDt;
            Địa_chỉ = diaChi;
            this.ngayMuaHang = ngayMuaHang;
            ID = iD;
            this.tongThanhToan = tongThanhToan;
            this.maGiaoDich = maGiaoDich;
        }
        public MuaHang(string iD)
        {
            ID = iD;
        }
    }
}
