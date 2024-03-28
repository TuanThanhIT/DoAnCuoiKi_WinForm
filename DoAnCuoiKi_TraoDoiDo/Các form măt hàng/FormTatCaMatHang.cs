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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAnCuoiKi_TraoDoiDo
{
    public partial class FormTatCaMatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FormTatCaMatHang()
        {
            InitializeComponent();
            
        }

        private void btnChiTiet(object sender, EventArgs e)
        {
            FormChiTiet f = new FormChiTiet();
            f.Show();
        }
        

        private void FormTatCaMatHang_Load(object sender, EventArgs e)
        {
            LoadDataIntoTextBoxes();   
        }
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DoAnTraoDoiDo;Integrated Security=True";
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

        public void LoadDataIntoTextBoxes()
        {
            string query = "";
            query = string.Format("SELECT [Tên_mặt_hàng], [Giá_bán], [Hình_ảnh_1]" +
                "FROM [ĐăngBán]" +
                "WHERE [Số_lượng] <> 0");
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UCHienThi uc = new UCHienThi();
                                uc.UCHTlblTen.Text = reader["Tên_mặt_hàng"].ToString();
                                uc.UCHTlblGia.Text = reader["Giá_bán"].ToString();
                                string imagePath = reader["Hình_ảnh_1"].ToString();
                                uc.UCHTPictureBox.Image = Image.FromFile(imagePath);
                                loadProductInfo(uc);
                                //connection.Open();
                                //SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
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
        public void loadProductInfo(UCHienThi uc)
        {
            uc.Margin = new Padding(35);
            flowLPHienthiAll.Controls.Add(uc);
        }




    }

}
