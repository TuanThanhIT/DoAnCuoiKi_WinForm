using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class DangKiDao
    {
        DBConnection db = new DBConnection();
        public void ThemThanhVien(DangKi dk)
        {
            string sqlStr = string.Format("INSERT INTO ĐăngKí(ID, Họ_tên, Ngày_tháng_năm_sinh, Giới_tính, Địa_chỉ_Email, Số_điện_thoại, Địa_chỉ, Ngày_đăng_kí, Tên_đăng_nhập, Mật_khẩu, Chức_vụ) " +
               "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", dk.ID, dk.Hoten, dk.Namsinh, dk.Gioitinh, dk.Email, dk.Sodt, dk.Diachi, dk.Ngaydangki, dk.Tendangnhap, dk.Matkhau, dk.Chucvu);
            db.Thucthi(sqlStr);
        }
    
    }
}
