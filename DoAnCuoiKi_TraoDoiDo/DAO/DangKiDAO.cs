using DoAnCuoiKi_TraoDoiDo.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class DangKiDAO
    {
        DBConnection db = new DBConnection();
        public static string ID;
        public static string Ten_nguoi_dung;
        public static string Chuc_vu;
        public static string Ho_ten;
        public static string Dia_chi;
        public static string So_dt;

        public bool ThemThanhVien(DangKi dk)
        {
            string sqlStr = string.Format("INSERT INTO ĐăngKí(ID, Họ_tên, Ngày_tháng_năm_sinh, Giới_tính, Địa_chỉ_Email, Số_điện_thoại, Địa_chỉ, Ngày_đăng_kí, Tên_đăng_nhập, Mật_khẩu, Chức_vụ) " +
              "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", dk.ID, dk.Hoten, dk.Namsinh, dk.Gioitinh, dk.Email, dk.Sodt, dk.Diachi, dk.Ngaydangki, dk.Tendangnhap, dk.Matkhau, dk.Chucvu);
            return db.Thucthi(sqlStr);
        }
        public List<DangKi> LoadDSDangKi()
        {
            string query2 = string.Format("SELECT *" +
            "FROM [ĐăngKí]");
            List<DangKi> dks = new List<DangKi>();
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
                                DangKi dk = new DangKi(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                    reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                                dks.Add(dk);

                            }

                        }
                    }
                }
            }
            return dks;

        }

    }
}
