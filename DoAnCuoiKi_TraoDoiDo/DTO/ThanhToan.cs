using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class ThanhToan : GioHang
    {
        private string thanhtien;
        public string ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        public ThanhToan(string iD, string maMatHang, string tenMatHang, string loaiMatHang, string giamoi, string hinhAnh, string soLuongMua, string maVoucher, string giamgia, string thanhtien)
        {
            ID = iD;
            Ma_San_Pham = maMatHang;
            Ten_Mat_Hang = tenMatHang;
            Loai_Mat_Hang = loaiMatHang;
            Gia_Ban = giamoi;
            Hinh_Anh_1 = hinhAnh;
            Soluongchon = soLuongMua;
            Ma_Voucher = maVoucher;
            Giam_Gia = giamgia;
            this.thanhtien = thanhtien;
        }
        public ThanhToan()
        {

        }
        public ThanhToan(string iD, string maMatHang, string tenMatHang, string loaiMatHang, string giamoi, string hinhAnh, string soLuongMua, string maVoucher, string giamgia, string soluongVou, string soluong)
        {
            ID = iD;
            Ma_San_Pham = maMatHang;
            Ten_Mat_Hang = tenMatHang;
            Loai_Mat_Hang = loaiMatHang;
            Gia_Ban = giamoi;
            Hinh_Anh_1 = hinhAnh;
            Soluongchon = soLuongMua;
            Ma_Voucher = maVoucher;
            Giam_Gia = giamgia;
            So_Luong_Voucher = soluongVou;
            So_Luong = soluong;
        }
        public ThanhToan(string thanhtien, string maMatHang)
        {
            this.thanhtien = thanhtien;
            Ma_San_Pham = maMatHang;
        }
    }

}


