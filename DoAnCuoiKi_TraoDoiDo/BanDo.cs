using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAnCuoiKi_TraoDoiDo
{
   
    public class BanDo
    {
        public string Ten_Mat_Hang { get; set; }
        public string Loai_Mat_Hang { get; set; }
        public float Gia_Ban { get; set; }
        public string Mo_ta_mat_hang { get; set; }
        public DateTime Ngay_Dang_Ban { get; set; }
        public string Hinh_Anh_1 { get; set; }
        public string Hinh_Anh_2 { get; set; }
        public string Hinh_Anh_3 { get; set; }
        public string Hinh_Anh_4 { get; set; }
        public string Ma_Voucher { get; set; }
        public float Giam_Gia { get; set; }
        public int So_Luong_Voucher { get; set; }
        public int So_Luong { get; set; }
        public string Dia_Diem { get; set; }
        public string Phuong_Thuc_Giao_Hang { get; set; }
        public string Tinh_Trang_Mat_Hang { get; set; }

        public BanDo()
        {

        }

        public BanDo(string ten_mat_hang, string loai_mat_hang, float gia_ban, string mo_ta_mat_hang, DateTime ngay_dang_ban, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                    string ma_voucher, float giam_gia, int so_luong_voucher, int so_luong, string dia_diem, string phuong_thuc_giao_hang, string tinh_trang_mat_hang)
        {
            Ten_Mat_Hang = ten_mat_hang;
            Loai_Mat_Hang = loai_mat_hang;
            Gia_Ban = gia_ban;
            Mo_ta_mat_hang = mo_ta_mat_hang;
            Ngay_Dang_Ban = ngay_dang_ban;
            Hinh_Anh_1 = hinh_anh_1;
            Hinh_Anh_2 = hinh_anh_2;
            Hinh_Anh_3 = hinh_anh_3;
            Hinh_Anh_4 = hinh_anh_4;
            Ma_Voucher = ma_voucher;
            Giam_Gia = giam_gia;
            So_Luong_Voucher = so_luong_voucher;
            So_Luong = so_luong;
            Dia_Diem = dia_diem;
            Phuong_Thuc_Giao_Hang = phuong_thuc_giao_hang;
            Tinh_Trang_Mat_Hang = tinh_trang_mat_hang;
        }
    }
}
