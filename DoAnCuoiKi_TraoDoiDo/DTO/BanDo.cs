using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.DTO
{
    public class BanDo : DangKi
    {
        public string Tên_mặt_hàng { get; set; }
        public string Loại_mặt_hàng { get; set; }
        public string Giá_bán { get; set; }
        public string Mô_tả_mặt_hàng { get; set; }
        public string Ngày_đăng_bán { get; set; }
        public string Hình_ảnh_1 { get; set; }
        public string Hình_ảnh_2 { get; set; }
        public string Hình_ảnh_3 { get; set; }
        public string Hình_ảnh_4 { get; set; }
        public string Mã_Voucher { get; set; }
        public string Giảm_giá{ get; set; }
        public string Số_lượng_Voucher { get; set; }
        public string Số_lượng { get; set; }
        public string Địa_điểm { get; set; }
        public string Phương_thức_giao_hàng { get; set; }
        public string Tình_trạng_mặt_hàng { get; set; }
        public string Mã_sản_phẩm { get; set; }
        public string Giá_gốc { get; set; }

        public string Lượt_xem { get; set; }

        public string Yêu_thích { get ; set; }  
        public BanDo()
        {

        }

        public BanDo(string ten_mat_hang, string loai_mat_hang, string gia_ban, string mo_ta_mat_hang, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                    string ma_voucher, string giam_gia, string so_luong_voucher, string so_luong, string dia_diem, string phuong_thuc_giao_hang, string tinh_trang_mat_hang, string ma_san_pham, string ngay_dang_ban, string iD, string gia_goc, string luot_xem, string yeu_thich)
        {
            Tên_mặt_hàng = ten_mat_hang;
            Loại_mặt_hàng = loai_mat_hang;
            Giá_bán = gia_ban;
            Mô_tả_mặt_hàng = mo_ta_mat_hang;
            Hình_ảnh_1 = hinh_anh_1;
            Hình_ảnh_2 = hinh_anh_2;
            Hình_ảnh_3 = hinh_anh_3;
            Hình_ảnh_4 = hinh_anh_4;
            Mã_Voucher = ma_voucher;
            Giảm_giá = giam_gia;
            Số_lượng_Voucher = so_luong_voucher;
            Số_lượng = so_luong;
            Địa_điểm = dia_diem;
            Phương_thức_giao_hàng = phuong_thuc_giao_hang;
            Tình_trạng_mặt_hàng = tinh_trang_mat_hang;
            Mã_sản_phẩm = ma_san_pham;
            Ngày_đăng_bán = ngay_dang_ban;
            ID = iD;
            Giá_gốc = gia_goc;
            Lượt_xem = luot_xem;
            Yêu_thích = yeu_thich;
        }
 
        public BanDo(string ten_mat_hang, string loai_mat_hang, string gia_ban, string mo_ta_mat_hang, string hinh_anh_1, string hinh_anh_2, string hinh_anh_3, string hinh_anh_4,
                   string ma_voucher, string giam_gia, string so_luong_voucher, string so_luong, string dia_diem, string phuong_thuc_giao_hang, string tinh_trang_mat_hang, string ma_san_pham, string ngay_dang_ban, string iD, string gia_goc)
        {
            Tên_mặt_hàng = ten_mat_hang;
            Loại_mặt_hàng = loai_mat_hang;
            Giá_bán = gia_ban;
            Mô_tả_mặt_hàng = mo_ta_mat_hang;
            Ngày_đăng_bán = ngay_dang_ban;
            Hình_ảnh_1 = hinh_anh_1;
            Hình_ảnh_2 = hinh_anh_2;
            Hình_ảnh_3 = hinh_anh_3;
            Hình_ảnh_4 = hinh_anh_4;
            Mã_Voucher = ma_voucher;
            Giảm_giá = giam_gia;
            Số_lượng_Voucher = so_luong_voucher;
            Số_lượng = so_luong;
            Địa_điểm = dia_diem;
            Phương_thức_giao_hàng = phuong_thuc_giao_hang;
            Tình_trạng_mặt_hàng = tinh_trang_mat_hang;
            Mã_sản_phẩm = ma_san_pham;
            ID = iD;
            Giá_gốc = gia_goc;

        }
        public BanDo(string iD, string ten_mat_hang, string loai_mat_hang, string so_luong, string hinh_anh_1, string gia_goc, string gia_ban, string ngay_dang_ban, string ma_san_pham, string ma_voucher, string giam_gia)
        {
            ID = iD;
            Tên_mặt_hàng = ten_mat_hang;
            Loại_mặt_hàng = loai_mat_hang;
            Số_lượng = so_luong;
            Hình_ảnh_1 = hinh_anh_1;
            Giá_gốc = gia_goc;
            Giá_bán = gia_ban;
            Ngày_đăng_bán = ngay_dang_ban;
            Mã_sản_phẩm = ma_san_pham;
            Mã_Voucher = ma_voucher;
            Giảm_giá = giam_gia;
        }
        public BanDo(string ten_mat_hang, string ma_san_pham, string ma_voucher, string giam_gia, string so_luong_vou)
        {
            Tên_mặt_hàng = ten_mat_hang;
            Mã_sản_phẩm = ma_san_pham;
            Mã_Voucher = ma_voucher;
            Giảm_giá = giam_gia;
            Số_lượng_Voucher = so_luong_vou;
        }
        public BanDo(string ten_mat_hang)
        {
            Tên_mặt_hàng = ten_mat_hang;
        }
        public BanDo(string so_luong_voucher, string so_luong, string ma_san_pham)
        {
            Số_lượng_Voucher = so_luong_voucher;
            Số_lượng = so_luong;
            Mã_sản_phẩm = ma_san_pham;
        }
        public BanDo (string ten_mat_hang, string ma_san_pham, string luot_xem, string yeu_thich)
        {
            Tên_mặt_hàng = ten_mat_hang;
            Mã_sản_phẩm = ma_san_pham;
            Lượt_xem = luot_xem;
            Yêu_thích = yeu_thich;
        }
    }
}
