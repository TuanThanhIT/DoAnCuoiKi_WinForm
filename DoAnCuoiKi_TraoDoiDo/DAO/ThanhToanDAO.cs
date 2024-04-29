using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class ThanhToanDAO
    {
        DBConnection db = new DBConnection();
        public void themThanhToan(ThanhToan tt)
        {
            string sqlStr = string.Format("INSERT INTO ThanhToán(ID, Mã_sản_phẩm, Tên_mặt_hàng, Loại_mặt_hàng, Giá_mới, Hình_ảnh, Số_lượng_chọn, Mã_Voucher, Giảm_giá, Thành_tiền) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", tt.ID, tt.Ma_San_Pham, tt.Ten_Mat_Hang, tt.Loai_Mat_Hang, tt.Gia_Ban, tt.Hinh_Anh_1, tt.Soluongchon, tt.Ma_Voucher, tt.Giam_Gia, tt.ThanhTien);
            db.Thucthi(sqlStr);
        }
        public void xoaThanhToan()
        {
            string sqlStr = string.Format("DELETE FROM ThanhToán");
            db.Thucthi(sqlStr);
        }
        public void SuaThanhToan(ThanhToan tt)
        {
            string sqlStr = string.Format("UPDATE ThanhToán SET Thành_tiền = '{0}'WHERE Mã_sản_phẩm = '{1}'",
                tt.ThanhTien, tt.Ma_San_Pham);
            db.Thucthi(sqlStr);
        }

        public List<ThanhToan> LoadDanhSach()
        {
            string query2 = string.Format("SELECT gh.[ID], gh.[Mã_sản_phẩm], gh.[Tên_mặt_hàng], gh.[Loại_mặt_hàng], [Giá_mới], [Hình_ảnh], [Số_lượng_chọn], gh.[Mã_Voucher], gh.[Giảm_giá], [Số_lượng_Voucher], gh.[Số_lượng]" +
            "FROM [GiỏHàng] as gh, [ĐăngBán] as db " +
            "WHERE gh.[Mã_sản_phẩm] = db.[Mã_sản_phẩm] and gh.ID = N'{0}' AND [Mã_kiểm_tra] = N'T' and gh.[Số_lượng] > 0", DangKiDAO.ID);
            List<ThanhToan> mhs = new List<ThanhToan>();
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
                                ThanhToan tt = new ThanhToan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                                mhs.Add(tt);
                            }


                        }
                    }
                }
            }
            return mhs;

        }
        public string TinhTienHang()
        {
            string query2 = "SELECT SUM(CAST(Thành_tiền AS FLOAT)) AS Tongtienhang FROM ThanhToán";
            string value = null;

            using (SqlConnection connection = db.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                value = reader.GetDouble(0).ToString();
                            }
                        }
                    }
                }
            }

            return value;
        }
    }
}
