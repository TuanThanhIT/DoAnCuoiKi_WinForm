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
    public partial class FormDangNhap : Form
    {
        XuLyHienThi xlht = new XuLyHienThi();
        List<DangKi> dangKis = new List<DangKi>();
        DangKi dk = new DangKi();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btnDNDangKi_Click(object sender, EventArgs e)
        {
            FormDangKi f = new FormDangKi();
            f.Show();
            this.Hide();
        }


        private void btnDNDangnhap_Click(object sender, EventArgs e)
        {
             if(checkDangnhap() == true)
             {
                DialogResult result =  MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    FormTrangChu f = new FormTrangChu(dk);
                    f.Show();
                    this.Hide();
                }    
             }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng đăng nhập lại");
            }
        }
        private string chucvu()
        {
            string cv;
            if (radQuantrivien.Checked == true)
            {
                cv = "Quan tri vien";
            }
            else
            {
                cv = "Thanh vien";
            }
            return cv;
        }
        private bool checkDangnhap()
        { 
            string checkcv = chucvu();
            foreach(DangKi j in dangKis) 
            {
                if(j.Tendangnhap == txtDNTen.Text && j.Matkhau == txtDNPass.Text && checkcv == j.Chucvu)
                {
                    dk = j;
                    return true;

                }
            }
            return false;

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            LoadDSDangKi();
        }
        private void LoadDSDangKi()
        {
            string query2 = "";
            query2 = string.Format("SELECT *" +
            "FROM [ĐăngKí]");
            using (SqlConnection connection = xlht.GetSqlConnection())
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
                                string id = reader["ID"].ToString();
                                string hoten = reader["Họ_tên"].ToString();
                                string namsinh = reader["Ngày_tháng_năm_sinh"].ToString();
                                string gioitinh = reader["Giới_tính"].ToString();
                                string email = reader["Địa_chỉ_Email"].ToString();
                                string sodt = reader["Số_điện_thoại"].ToString();
                                string diachi = reader["Địa_chỉ"].ToString();
                                string ngaydangki = reader["Ngày_đăng_kí"].ToString();
                                string tendangnhap = reader["Tên_đăng_nhập"].ToString();
                                string matkhau = reader["Mật_khẩu"].ToString();
                                string chucvu = reader["Chức_vụ"].ToString();
                                DangKi dk = new DangKi(id, hoten, namsinh, gioitinh, email, sodt, diachi, ngaydangki, tendangnhap, matkhau, chucvu);
                                dangKis.Add(dk);

                            }

                        }
                    }
                }
            }
        }


    }
}
