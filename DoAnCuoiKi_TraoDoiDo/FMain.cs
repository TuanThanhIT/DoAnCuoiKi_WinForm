using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormMain : Form
    {
        XuLyHienThi xlht =new XuLyHienThi();
        public FormMain()
        {
            InitializeComponent();
        }
        string htVoucher = "MaVoucher";
        private void FormMain_Load(object sender, EventArgs e)
        {
            xlht.LoadDanhSach(htVoucher, flowLPMainVoucher);
            LoadDanhSachSuKien();
        }
        public void LoadDanhSachSuKien()
        {
            string query2 = "";
            query2 = string.Format("SELECT *" +
            "FROM [SựKiện]");

            using (SqlConnection connection = xlht.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            XuLySuKien.suKiens = new List<SuKien>();
                            while (reader.Read())
                            { 
                                string tenSukien = reader["Tên_sự_kiện"].ToString();
                                string giamGia = reader["Giảm_giá"].ToString();
                                string batDau = reader["Bắt_đầu"].ToString();
                                string ketThuc = reader["Kết_thúc"].ToString();
                                SuKien sk = new SuKien(tenSukien, giamGia, batDau, ketThuc);
                                XuLySuKien.suKiens.Add(sk);
                            }
                            foreach (SuKien sk in XuLySuKien.suKiens)
                            {
                                UCSuKien ucsk = new UCSuKien(sk);
                                ucsk.Margin = new Padding(0, 0, 0, 8);
                                flowLPMainSukien.Controls.Add(ucsk);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu được trả về!");
                        }
                    }
                }
            }
        }
    }
}
