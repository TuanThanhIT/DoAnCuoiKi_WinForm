using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class GioHangDao
    {
        DBConnection db = new DBConnection();
        public void ThemGioHang(GioHang bd)
        {
            string sqlStr = string.Format("INSERT INTO GiỏHàng(ID, Tên_người_dùng, Tên_mặt_hàng, Loại_mặt_hàng, Số_lượng, Hình_ảnh, Giá_cũ, Giá_mới, Số_lượng_chọn, Ngày_đăng_bán, Mã_sản_phẩm, Mã_kiểm_tra) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", bd.ID, bd.Ten_Nguoi_Dung, bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.So_Luong, bd.Hinh_Anh_1, bd.Gia_Goc, bd.Gia_Ban, bd.So_Luong_Chon, bd.Ngay_Dang_Ban, bd.Ma_San_Pham, bd.MaKiemTra);
            db.Thucthi(sqlStr);
        }
        public void XoaGH(GioHang gh)
        {

            string sqlStr = string.Format("DELETE FROM GiỏHàng WHERE Mã_sản_phẩm = '{0}'", gh.Ma_San_Pham);
            db.Thucthi(sqlStr);
        }
        public void SuaGH(GioHang bd)
        {
            string sqlStr = string.Format("UPDATE GiỏHàng SET ID = '{0}', Tên_người_dùng = '{1}', Tên_mặt_hàng = '{2}', Loại_mặt_hàng = '{3}', Số_lượng = '{4}', Hình_ảnh = '{5}', Giá_cũ = '{6}', Giá_mới = '{7}', Số_lượng_chọn = '{8}', Ngày_đăng_bán = '{9}', Mã_kiểm_tra = '{10}' WHERE Mã_sản_phẩm = '{11}'",
                bd.ID, bd.Ten_Nguoi_Dung, bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.So_Luong, bd.Hinh_Anh_1, bd.Gia_Goc, bd.Gia_Ban, bd.So_Luong_Chon, bd.Ngay_Dang_Ban, bd.MaKiemTra, bd.Ma_San_Pham);
            db.Thucthi(sqlStr);
        }
    }
}
