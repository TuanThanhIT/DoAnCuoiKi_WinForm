using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class BanDoDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public void Them(BanDo bd)
        {
            string sqlStr = string.Format("INSERT INTO ĐăngBán(Tên_mặt_hàng, Loại_mặt_hàng, Giá_bán, Mô_tả_mặt_hàng, Ngày_đăng_bán, Hình_ảnh_1, Hình_ảnh_2, Hình_ảnh_3, Hình_ảnh_4, Mã_Voucher, Giảm_giá, Số_lượng_Voucher, Số_lượng, Địa_điểm, Phương_thức_giao_hàng, Tình_trạng_mặt_hàng) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')", bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.Gia_Ban, bd.Mo_ta_mat_hang, bd.Ngay_Dang_Ban, bd.Hinh_Anh_1, bd.Hinh_Anh_2, bd.Hinh_Anh_3, bd.Hinh_Anh_4,
                bd.Ma_Voucher, bd.Giam_Gia, bd.So_Luong_Voucher, bd.So_Luong, bd.Dia_Diem, bd.Phuong_Thuc_Giao_Hang, bd.Tinh_Trang_Mat_Hang);
            db.Thucthi(sqlStr);


        }
        public void Xoa(BanDo bd)
        {

            string sqlStr = string.Format("DELETE FROM ĐăngBán WHERE Tên_mặt_hàng = '{0}'", bd.Ten_Mat_Hang);
            db.Thucthi(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM ĐăngBán");
            return db.Load(sqlStr);

        }
    }
}
