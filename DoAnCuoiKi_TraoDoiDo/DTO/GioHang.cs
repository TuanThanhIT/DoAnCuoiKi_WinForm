using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class GioHang : BanDo
    {
        private string makiemtra;
        private string soluongchon;
        public string MaKiemTra
        {
            get { return makiemtra; }
            set { makiemtra = value; }
        }
        public string Soluongchon
        {
            get { return soluongchon; }
            set { soluongchon = value; }
        }

        public GioHang(string iD, string ten_mat_hang, string loai_mat_hang, string so_luong, string hinh_anh_1, string gia_goc, string gia_ban, string so_luong_chon, string ngay_dang_ban, string ma_san_pham, string ma_kiem_tra, string ma_voucher, string giam_gia)
            : base(iD, ten_mat_hang, loai_mat_hang, so_luong, hinh_anh_1, gia_goc, gia_ban, ngay_dang_ban, ma_san_pham, ma_voucher, giam_gia)
        {
            makiemtra = ma_kiem_tra;
            soluongchon = so_luong_chon;
        }
        public GioHang(string ma_san_pham)
        {
            Mã_sản_phẩm = ma_san_pham;
        }
        public GioHang(string soluong, string ma_san_pham)
        {
            Số_lượng = soluong;
            Mã_sản_phẩm = ma_san_pham;
        }
        public GioHang() { }
    }
}
