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
        public string NgayMuaHang
        {
            get { return ngayMuaHang; }
            set { ngayMuaHang = value; }
        }
        public string TongThanhToan
        {
            get { return tongThanhToan; }
            set { tongThanhToan = value; }
        }
        public string MaGiaoDich
        {
            get { return maGiaoDich; }
            set { maGiaoDich = value; }
        }
        public MuaHang()
        {

        }
        public MuaHang(string hoTen, string soDt, string diaChi, string ngayMuaHang, string iD, string tongThanhToan, string maGiaoDich)
        {
            Hoten = hoTen;
            Sodt = soDt;
            Diachi = diaChi;
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
