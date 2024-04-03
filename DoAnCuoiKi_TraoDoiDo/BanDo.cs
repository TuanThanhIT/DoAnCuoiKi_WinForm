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
        public string Gia_Ban { get; set; }
        public string Mo_ta_mat_hang { get; set; }
        public string Ngay_Dang_Ban { get; set; }
        public string Hinh_Anh_1 { get; set; }
        public string Hinh_Anh_2 { get; set; }
        public string Hinh_Anh_3 { get; set; }
        public string Hinh_Anh_4 { get; set; }
        public string Ma_Voucher { get; set; }
        public string Giam_Gia { get; set; }
        public string So_Luong_Voucher { get; set; }
        public string So_Luong { get; set; }
        public string Dia_Diem { get; set; }
        public string Phuong_Thuc_Giao_Hang { get; set; }
        public string Tinh_Trang_Mat_Hang { get; set; }

        public string Ma_San_Pham { get; set; } 

        public BanDo()
        {

        }

        public BanDo(string ten_mat_hang, string loai_mat_hang, string gia_ban, string mo_ta_mat_hang, string ngay_dang_ban, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                    string ma_voucher, string giam_gia, string so_luong_voucher, string so_luong, string dia_diem, string phuong_thuc_giao_hang, string tinh_trang_mat_hang, string ma_san_pham)
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
            Ma_San_Pham = ma_san_pham;
        }
        public BanDo(string ma_san_pham, string ten_mat_hang, string loai_mat_hang, string gia_ban, string mo_ta_mat_hang, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                     string so_luong, string so_luong_voucher,  string phuong_thuc_giao_hang, string tinh_trang_mat_hang, string dia_diem)
        {
            Ma_San_Pham = ma_san_pham;
            Ten_Mat_Hang = ten_mat_hang;
            Loai_Mat_Hang = loai_mat_hang;
            Gia_Ban = gia_ban;
            Mo_ta_mat_hang = mo_ta_mat_hang;
            Hinh_Anh_1 = hinh_anh_1;
            Hinh_Anh_2 = hinh_anh_2;
            Hinh_Anh_3 = hinh_anh_3;
            Hinh_Anh_4 = hinh_anh_4;
            So_Luong = so_luong;
            So_Luong_Voucher = so_luong_voucher;
            Phuong_Thuc_Giao_Hang = phuong_thuc_giao_hang;
            Tinh_Trang_Mat_Hang = tinh_trang_mat_hang;
            Dia_Diem = dia_diem;
        }
    }
}
