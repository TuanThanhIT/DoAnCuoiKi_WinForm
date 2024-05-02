using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DAO
{
    public class DanhGiaDAO
    {
        DBConnection db = new DBConnection();
        public bool ThemDanhGia(DanhGia dg)
        {
            string sqlStr = string.Format("INSERT INTO ĐánhGiá(ID, Tên_người_dùng, Tên_sản_phẩm, Mã_sản_phẩm, Hình_ảnh, Viết_đánh_giá, Sao_đánh_giá) " +
              "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",dg.ID, dg.Tên_đăng_nhập, dg.Tên_mặt_hàng, dg.Mã_sản_phẩm, dg.Hình_ảnh_1, dg.VietDanhGia, dg.SaoDanhGia );
            return db.Thucthi(sqlStr);
        }
        public List<DanhGia> LoadDanhGia(string maSanPham)
        {
            string query2 = string.Format("SELECT *" +
            "FROM [ĐánhGiá] " +
            "WHERE [Mã_sản_phẩm] = N'{0}'", maSanPham);
            List<DanhGia> dgs = new List<DanhGia>();
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
                                DanhGia dg = new DanhGia(reader.GetString(1), reader.GetString(6), reader.GetString(5));
                                dgs.Add(dg);



                            }


                        }
                    }
                }
            }
            return dgs;

        }
    }
}
