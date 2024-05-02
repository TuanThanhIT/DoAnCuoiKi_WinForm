using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class DangKi
    {
        private string id;
        private string hoten;
        private string namsinh;
        private string gioitinh;
        private string email;
        private string sodt;
        private string diachi;
        private string ngaydangki;
        private string tendangnhap;
        private string matkhau;
        private string chucvu;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Họ_tên
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Ngày_tháng_năm_sinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        public string Giới_tính
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Địa_chỉ_Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Số_điện_thoại
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Địa_chỉ
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Ngày_đăng_kí
        {
            get { return ngaydangki; }
            set { ngaydangki = value; }
        }
        public string Tên_đăng_nhập
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        public string Mật_khẩu
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Chức_vụ
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public DangKi(string iD, string hoTen, string namSinh, string gioiTinh, string eMail, string soDt, string diaChi, string ngayDangki, string tenDangnhap, string matKhau, string chucVu)
        {

            id = iD;
            hoten = hoTen;
            namsinh = namSinh;
            gioitinh = gioiTinh;
            email = eMail;
            sodt = soDt;
            diachi = diaChi;
            ngaydangki = ngayDangki;
            tendangnhap = tenDangnhap;
            matkhau = matKhau;
            chucvu = chucVu;
        }
        public DangKi() { }
    }
}
