using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class SuKienDAO
    {
        DBConnection db = new DBConnection();
        public static List<SuKien> suKienList;
        public bool ThemSuKien(SuKien sk)
        {
            string sqlStr = string.Format("INSERT INTO SựKiện(Tên_sự_kiện, Giảm_giá, Bắt_đầu, Kết_thúc) " + "VALUES ('{0}', '{1}', '{2}', '{3}')", sk.TenSuKien, sk.GiamGia, sk.BatDau, sk.KetThuc);
            return db.Thucthi(sqlStr);
        }
        public bool XoaSuKien(SuKien sk)
        {
            string sqlStr = string.Format("DELETE FROM SựKiện WHERE Tên_sự_kiện = '{0}'", sk.TenSuKien);
            return db.Thucthi(sqlStr);
        }
        public bool SuaSuKien(SuKien sk)
        {
            string sqlStr = string.Format("UPDATE SựKiện SET Giảm_giá = '{1}', Bắt_đầu = '{2}', Kết_thúc = '{3}'  WHERE Tên_sự_kiện = '{0}'", sk.TenSuKien, sk.GiamGia, sk.BatDau, sk.KetThuc);
            return db.Thucthi(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT [Tên_sự_kiện] as [Sự kiện], [Giảm_giá] as [Giảm giá (%)], [Bắt_đầu] as [Bắt đầu], [Kết_thúc] as [Kết thúc]" +
                "FROM SựKiện");
            return db.Load(sqlStr);
        }
        public List<SuKien> LoadAll()
        {
            string query2 = "";
            query2 = string.Format("SELECT *" +
            "FROM [SựKiện]");
            List<SuKien> suKiens = new List<SuKien>();
            suKienList = new List<SuKien>();
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
                                string tenSukien = reader["Tên_sự_kiện"].ToString();
                                string giamGia = reader["Giảm_giá"].ToString();
                                string batDau = reader["Bắt_đầu"].ToString();
                                string ketThuc = reader["Kết_thúc"].ToString();
                                SuKien sk = new SuKien(tenSukien, giamGia, batDau, ketThuc);
                                suKiens.Add(sk);
                                suKienList.Add(sk);
                            }
                        }
                    }
                }
            }
            return suKiens;
        }

    }
}
