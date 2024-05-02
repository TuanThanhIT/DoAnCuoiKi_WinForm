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
            Tên_đăng_nhập = tenNguoiDung;
            Tên_mặt_hàng = tenSanPham;
            Mã_sản_phẩm = maSanPham;
            Hình_ảnh_1 = hinhAnh;
            this.vietDanhGia = vietDanhGia;
            this.saoDanhGia = saoDanhGia;
        }
        public DanhGia(string tenNguoiDung, string saoDanhGia, string vietDanhGia)
        {
            Tên_đăng_nhập = tenNguoiDung;
            this.saoDanhGia = saoDanhGia;
            this.vietDanhGia = vietDanhGia;
        }
    }
}
