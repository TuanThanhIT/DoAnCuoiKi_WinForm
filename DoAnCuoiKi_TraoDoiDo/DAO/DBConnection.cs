using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public bool Thucthi(string s)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(s, conn))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Đóng kết nối trước khi trả về giá trị
                    conn.Close();

                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi và đóng kết nối
                conn.Close();
                return false;
            }
        }
        public void Thucthi2(string s)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(s, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable Load(string s)
        {

            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        private string stringConnections = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DoAnTraoDoiDo;Integrated Security=True";
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnections);
        }



    }
}
