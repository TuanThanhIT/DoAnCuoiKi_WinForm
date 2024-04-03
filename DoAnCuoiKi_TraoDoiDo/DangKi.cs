using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
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
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh;}
            set { gioitinh = value;}
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Sodt
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Ngaydangki
        {
            get { return ngaydangki; }
            set { ngaydangki = value;}
        }
        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value;}
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value;}
        }
        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public DangKi(string iD, string hoten, string namsinh, string gioitinh, string email, string sodt, string diachi, string ngaydangki, string tendangnhap, string matkhau, string chucvu)
        {
            
            ID = iD;
            Hoten = hoten;
            Namsinh = namsinh;
            Gioitinh = gioitinh;
            Email = email;
            Sodt = sodt;
            Diachi = diachi;
            Ngaydangki = ngaydangki;
            Tendangnhap = tendangnhap;
            Matkhau = matkhau;
            Chucvu = chucvu;
        }
    }
}
