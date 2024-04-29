using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class DanhGia : BanDo
    {
        private string saoDanhGia;
        private string vietDanhGia;

        public string SaoDanhGia
        {
            get { return saoDanhGia; }
            set { saoDanhGia = value; }
        }
        public string VietDanhGia
        {
            get { return vietDanhGia; }
            set { vietDanhGia = value; }
        } 
        public DanhGia(string iD, string tenNguoiDung,  string tenSanPham, string maSanPham, string hinhAnh, string vietDanhGia, string saoDanhGia)
        {
            ID = iD;
            Tendangnhap = tenNguoiDung;
            Ten_Mat_Hang = tenSanPham;
            Ma_San_Pham = maSanPham;
            Hinh_Anh_1 = hinhAnh;
            this.vietDanhGia = vietDanhGia;
            this.saoDanhGia = saoDanhGia;
        }
        public DanhGia(string tenNguoiDung, string saoDanhGia, string vietDanhGia)
        {
            Tendangnhap = tenNguoiDung;
            this.saoDanhGia = saoDanhGia;
            this.vietDanhGia = vietDanhGia;
        }
    }
}
