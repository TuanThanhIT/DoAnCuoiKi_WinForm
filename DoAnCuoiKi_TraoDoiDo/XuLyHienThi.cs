using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class XuLyHienThi
    {
        private string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DoAnTraoDoiDo;Integrated Security=True";
       
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }


        public void LoadDanhSach(string a, FlowLayoutPanel fl)
        {
            string query2 = "";
            query2 = string.Format("SELECT *" +
            "FROM [ĐăngBán]");

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            List<BanDo> bds = new List<BanDo>();
                            while (reader.Read())
                            {

                                string tenmathang = reader["Tên_mặt_hàng"].ToString();
                                string loaimathang = reader["Loại_mặt_hàng"].ToString();
                                string giaban = reader["Giá_bán"].ToString();
                                string motamathang = reader["Mô_tả_mặt_hàng"].ToString();
                                string hinhanh1 = reader["Hình_ảnh_1"].ToString();
                                string hinhanh2 = reader["Hình_ảnh_2"].ToString();
                                string hinhanh3 = reader["Hình_ảnh_3"].ToString();
                                string hinhanh4 = reader["Hình_ảnh_4"].ToString();
                                string mavoucher = reader["Mã_Voucher"].ToString();
                                string giamgia = reader["Giảm_giá"].ToString();
                                string soluong = reader["Số_lượng"].ToString();
                                string ptgiaohang = reader["Phương_thức_giao_hàng"].ToString();
                                string tinhtrangmh = reader["Tình_trạng_mặt_hàng"].ToString();
                                string soluongVou = reader["Số_lượng_Voucher"].ToString();
                                string diadiem = reader["Địa_điểm"].ToString();
                                string masanpham = reader["Mã_sản_phẩm"].ToString();
                                string ngaydangban = reader["Ngày_đăng_bán"].ToString();
                                BanDo bd = new BanDo(tenmathang, loaimathang, giaban, motamathang, ngaydangban, hinhanh1, hinhanh2, hinhanh3, hinhanh4,mavoucher, giamgia, soluongVou, soluong, diadiem, ptgiaohang, tinhtrangmh, masanpham);
                                bds.Add(bd);

                            }
                            foreach (BanDo j in bds)
                            {
                                if( a == "All")
                                {
                                    UCHienThi ucht = new UCHienThi(j);
                                    ucht.Margin = new Padding(8);
                                    fl.Controls.Add(ucht);
                                }
                                if(a == j.Loai_Mat_Hang)
                                {
                                    UCHienThi ucht = new UCHienThi(j);
                                    ucht.Margin = new Padding(8);
                                    fl.Controls.Add(ucht);
                                }
                                if(a == "MaVoucher")
                                {
                                    UCVoucher ucvc = new UCVoucher(j);
                                    ucvc.Margin = new Padding(0,0,0,8); 
                                    fl.Controls.Add(ucvc);
                                }    
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
