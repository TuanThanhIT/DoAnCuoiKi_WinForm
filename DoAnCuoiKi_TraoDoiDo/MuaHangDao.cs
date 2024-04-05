using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{   
    public class MuaHangDao
    {
        DBConnection db = new DBConnection();
        public void ThemMuaHang(MuaHang mh)
        {
            string sqlStr = string.Format("INSERT INTO MuaHàng(Họ_tên_người_mua, Số_điện_thoại, Địa_chỉ, Ngày_mua_hàng, Mã_mặt_hàng, Tên_mặt_hàng, Loại_mặt_hàng, Số_lượng_mua, Mã_Voucher, Giảm_giá_Voucher, Giảm_giá_sự_kiện)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",mh.HoTen, mh.SoDt, mh.DiaChi, mh.NgayMuaHang, mh.MaMatHang, mh.TenMatHang, mh.LoaiMatHang, mh.SoLuongMua, mh.MaVoucher, mh.GiamGiaVou, mh.GiamGiaSK);
            db.Thucthi(sqlStr);
        }
    }
}
