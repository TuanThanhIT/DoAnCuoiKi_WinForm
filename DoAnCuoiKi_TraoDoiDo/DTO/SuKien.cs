using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class SuKien
    {
        private string tenSuKien;
        private string giamGia;
        private string batDau;
        private string ketThuc;

        public string TenSuKien
        {
            get { return tenSuKien; }
            set { tenSuKien = value; }
        }
        public string GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        public string BatDau
        {
            get { return batDau; }
            set { batDau = value; }
        }
        public string KetThuc
        {
            get { return ketThuc; }
            set { ketThuc = value; }
        }

        public SuKien()
        {

        }
        public SuKien(string tenSuKien, string giamGia, string batDau, string ketThuc)
        {
            this.tenSuKien = tenSuKien;
            this.giamGia = giamGia;
            this.batDau = batDau;
            this.ketThuc = ketThuc;
        }
        public SuKien(string tenSuKien)
        {
            this.tenSuKien = tenSuKien;
        }
    }
}
