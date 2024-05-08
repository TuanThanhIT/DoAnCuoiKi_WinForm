using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DAO
{
    public class DAO
    {
        DBConnection db = new DBConnection();
        public List<MuaHang> LoadDanhSachMuaHang(string query2)
        {
            List<MuaHang> mhs = new List<MuaHang>();
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
                                MuaHang gh = new MuaHang(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                                mhs.Add(gh);



                            }


                        }
                    }
                }
            }
            return mhs;
        }
        public List<BanDo> LoadDanhSachDangBan2(string query2)
        {
            List<BanDo> listBD = new List<BanDo>();
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
                                BanDo bd = new BanDo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15),
                                    reader.GetString(16), reader.GetString(17), reader.GetString(18), reader.GetString(19), reader.GetString(20));
                                listBD.Add(bd);


                            }


                        }
                    }
                }
            }

            return listBD;


        }
        public List<BanDo> LoadDanhSachDangBan(string query2)
        {
            List<BanDo> listBD = new List<BanDo>();
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
                                BanDo bd = new BanDo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15),
                                    reader.GetString(16), reader.GetString(17), reader.GetString(18));
                                listBD.Add(bd);


                            }


                        }
                    }
                }
            }

            return listBD;


        }
    }
}
