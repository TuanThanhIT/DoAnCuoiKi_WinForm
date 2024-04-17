using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class GioHang:BanDo
    {
        private string makiemtra;
        public string MaKiemTra
        {
            get { return makiemtra; }
            set { makiemtra = value; }
        }

        public GioHang(string iD, string ten_nguoi_dung, string ten_mat_hang, string loai_mat_hang, string so_luong, string hinh_anh_1, string gia_goc, string gia_ban, string so_luong_chon, string ngay_dang_ban, string ma_san_pham, string ma_kiem_tra):base(iD ,ten_nguoi_dung,ten_mat_hang, loai_mat_hang, so_luong, hinh_anh_1, gia_goc, gia_ban, so_luong_chon, ngay_dang_ban, ma_san_pham)
        {
            MaKiemTra = ma_kiem_tra;
        }
    }
}
