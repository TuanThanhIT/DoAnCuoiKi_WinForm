using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class MuaHang
    {
        private string hoTen;
        private string soDt;
        private string diaChi;
        private string ngayMuaHang;
        private string maMatHang;
        private string tenMatHang;
        private string loaiMatHang;
        private string soLuongMua;
        private string maVoucher;
        private string giamGiaVou;
        private string giamGiaSK;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string SoDt
        {
            get { return soDt; }
            set { soDt = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string NgayMuaHang
        {
            get { return ngayMuaHang; }
            set { ngayMuaHang = value; }
        }
        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        public string TenMatHang
        {
            get { return tenMatHang; }
            set { tenMatHang = value; }
        }
        public string LoaiMatHang
        {
            get { return loaiMatHang; }
            set { loaiMatHang = value; }
        }
        public string SoLuongMua
        {
            get { return soLuongMua; }
            set { soLuongMua = value; }
        }
        public string MaVoucher
        {
            get { return maVoucher; }
            set { maVoucher = value; }
        }
        public string GiamGiaVou
        {
            get { return giamGiaVou; }
            set { giamGiaVou = value; }
        }
        public string GiamGiaSK
        {
            get { return giamGiaSK; }
            set { giamGiaSK = value; }
        }

        public MuaHang(string hoTen, string soDt, string diaChi, string ngayMuaHang, string maMatHang, string tenMatHang, string loaiMatHang, string soLuongMua, string maVoucher, string giamGiaVou, string giamGiaSK)
        {
            this.hoTen = hoTen;
            this.soDt = soDt;
            this.diaChi = diaChi;
            this.ngayMuaHang = ngayMuaHang;
            this.maMatHang = maMatHang;
            this.tenMatHang = tenMatHang;
            this.loaiMatHang = loaiMatHang;
            this.soLuongMua = soLuongMua;
            this.maVoucher = maVoucher;
            this.giamGiaVou = giamGiaVou;
            this.giamGiaSK = giamGiaSK;
        }

    }
    
}   
        

