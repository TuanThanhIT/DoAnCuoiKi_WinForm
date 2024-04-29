using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class GioHangDAO
    {
        DBConnection db = new DBConnection();
        public bool ThemGioHang(GioHang bd)
        {
            string sqlStr = string.Format("INSERT INTO GiỏHàng(ID, Tên_mặt_hàng, Loại_mặt_hàng, Số_lượng, Hình_ảnh, Giá_cũ, Giá_mới, Số_lượng_chọn, Ngày_đăng_bán, Mã_sản_phẩm, Mã_kiểm_tra, Mã_Voucher, Giảm_giá) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", bd.ID, bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.So_Luong, bd.Hinh_Anh_1, bd.Gia_Goc, bd.Gia_Ban, bd.Soluongchon, bd.Ngay_Dang_Ban, bd.Ma_San_Pham, bd.MaKiemTra, bd.Ma_Voucher, bd.Giam_Gia);
            return db.Thucthi(sqlStr);
        }
        public bool XoaGH(GioHang gh)
        {
            string sqlStr = string.Format("DELETE FROM GiỏHàng WHERE Mã_sản_phẩm = '{0}'", gh.Ma_San_Pham);
            return db.Thucthi(sqlStr);

        }

        public bool SuaGioHang(GioHang bd)
        {
            string sqlStr = string.Format("UPDATE GiỏHàng SET ID = '{0}', Tên_mặt_hàng = '{1}', Loại_mặt_hàng = '{2}', Số_lượng = '{3}', Hình_ảnh = '{4}', Giá_cũ = '{5}', Giá_mới = '{6}', Số_lượng_chọn = '{7}', Ngày_đăng_bán = '{8}', Mã_kiểm_tra = '{9}', Mã_Voucher = '{10}', Giảm_giá = '{11}' WHERE Mã_sản_phẩm = '{12}'",
              bd.ID, bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.So_Luong, bd.Hinh_Anh_1, bd.Gia_Goc, bd.Gia_Ban, bd.Soluongchon, bd.Ngay_Dang_Ban, bd.MaKiemTra, bd.Ma_Voucher, bd.Giam_Gia, bd.Ma_San_Pham);
            return db.Thucthi(sqlStr);
        }
        public void SuaGH(GioHang gh)//Sửa số lượng khi thanh toán
        {
            string sqlStr = string.Format("UPDATE GiỏHàng SET Số_lượng = '{0}' WHERE Mã_sản_phẩm = '{1}'", gh.So_Luong, gh.Ma_San_Pham);
            db.Thucthi(sqlStr);
        }
        public List<GioHang> LoadDanhSach()
        {
            string query2 = string.Format("SELECT *" +
            "FROM [GiỏHàng] " +
            "WHERE ID = N'{0}' and [Số_lượng] > 0", DangKiDAO.ID);
            List<GioHang> ghs = new List<GioHang>();
            using (SqlConnection connection = db.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                GioHang gh = new GioHang(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
                                ghs.Add(gh);



                            }


                        }
                    }
                }
            }
            return ghs;

        }
    }
}
