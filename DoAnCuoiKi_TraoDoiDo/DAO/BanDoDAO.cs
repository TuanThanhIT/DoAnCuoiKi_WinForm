using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class BanDoDAO
    {
        DBConnection db = new DBConnection();

        public bool ThemMatHang(BanDo bd)
        {

            string sqlStr = string.Format("INSERT INTO ĐăngBán(Tên_mặt_hàng, Loại_mặt_hàng, Giá_bán, Mô_tả_mặt_hàng, Ngày_đăng_bán, Hình_ảnh_1, Hình_ảnh_2, Hình_ảnh_3, Hình_ảnh_4, Mã_Voucher, Giảm_giá, Số_lượng_Voucher, Số_lượng, Địa_điểm, Phương_thức_giao_hàng, Tình_trạng_mặt_hàng, Mã_sản_phẩm, ID, Giá_gốc) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}')", bd.Ten_Mat_Hang, bd.Loai_Mat_Hang, bd.Gia_Ban, bd.Mo_ta_mat_hang, bd.Ngay_Dang_Ban, bd.Hinh_Anh_1, bd.Hinh_Anh_2, bd.Hinh_Anh_3, bd.Hinh_Anh_4,
                bd.Ma_Voucher, bd.Giam_Gia, bd.So_Luong_Voucher, bd.So_Luong, bd.Dia_Diem, bd.Phuong_Thuc_Giao_Hang, bd.Tinh_Trang_Mat_Hang, bd.Ma_San_Pham, bd.ID, bd.Gia_Goc);
            return db.Thucthi(sqlStr);


        }
        public bool XoaMatHang(BanDo bd)
        {
            string sqlStr = string.Format("DELETE FROM ĐăngBán WHERE Tên_mặt_hàng = '{0}'", bd.Ten_Mat_Hang);
            return db.Thucthi(sqlStr);
        }
        public bool SuaMatHang(BanDo bd)
        {
            string sqlStr = string.Format("UPDATE [ĐăngBán] SET  [Loại_mặt_hàng] = '{0}', [Giá_bán] = '{1}', [Mô_tả_mặt_hàng] = '{2}', [Hình_ảnh_1] = '{3}', [Hình_ảnh_2] = '{4}', [Hình_ảnh_3] = '{5}', [Hình_ảnh_4] = '{6}', [Mã_Voucher] = '{7}', [Giảm_giá] = '{8}', [Số_lượng_Voucher] = '{9}', [Số_lượng] = '{10}', [Địa_điểm] = '{11}', [Phương_thức_giao_hàng] = '{12}', [Tình_trạng_mặt_hàng] = '{13}', [Mã_sản_phẩm] = '{14}', [Ngày_đăng_bán] = '{15}', [ID] = '{16}', [Giá_gốc] = '{17}' where [Tên_mặt_hàng] = '{18}'",
                bd.Loai_Mat_Hang, bd.Gia_Ban, bd.Mo_ta_mat_hang, bd.Hinh_Anh_1, bd.Hinh_Anh_2, bd.Hinh_Anh_3, bd.Hinh_Anh_4, bd.Ma_Voucher, bd.Giam_Gia, bd.So_Luong_Voucher, bd.So_Luong, bd.Dia_Diem, bd.Phuong_Thuc_Giao_Hang, bd.Tinh_Trang_Mat_Hang, bd.Ma_San_Pham, bd.Ngay_Dang_Ban, bd.ID, bd.Gia_Goc, bd.Ten_Mat_Hang);
            return db.Thucthi(sqlStr);
        }
        public void SuaMatHang1(BanDo bd) //Thay đổi số lượng Voucher khi áp mã thành công và khi mua hàng thành công
        {
            string sqlStr = string.Format("UPDATE [ĐăngBán] SET Số_lượng_Voucher = '{0}', Số_lượng = '{1}' WHERE Mã_sản_phẩm = '{2}'",
                bd.So_Luong_Voucher, bd.So_Luong, bd.Ma_San_Pham);
            db.Thucthi(sqlStr);
        }
       
        public DataTable DanhSachDangBan()
        {
            string sqlStr = string.Format("select [Tên_mặt_hàng] as [Tên sản phẩm], [Loại_mặt_hàng] as [Loại sản phẩm], [Giá_bán] as [Giá bán], [Mô_tả_mặt_hàng] as [Mô tả],  [Hình_ảnh_1] as [Đường dẫn ảnh], [Hình_ảnh_2] as [Đường dẫn ảnh 2], [Hình_ảnh_3] as [Đường dẫn ảnh 3], [Hình_ảnh_4] as [Đường dẫn ảnh 4], [Mã_Voucher] as [Mã Voucher], [Giảm_giá] as [Giảm giá (%)], [Số_lượng_Voucher] as [Số lượng Voucher], [Số_lượng] as [Số lượng bán], [Địa_điểm] as [Địa điểm], [Phương_thức_giao_hàng] as [Phương thức giao hàng], [Tình_trạng_mặt_hàng] as [Tình trạng sản phẩm], Mã_sản_phẩm as [Mã sản phẩm],[Ngày_đăng_bán] as [Ngày đăng bán], ID, Giá_gốc as [Giá gốc]" +
                "from [ĐăngBán] where [Số_lượng] > 0 and ID = N'{0}'", DangKiDAO.ID);
            return db.Load(sqlStr);
        }


        public List<BanDo> LoadDanhSach()
        {
            string query2 = string.Format("SELECT * FROM [ĐăngBán] WHERE Số_lượng > 0 and [Số_lượng_Voucher] > 0");
            List<BanDo> listBD = new List<BanDo>();
            using (SqlConnection connection = db.GetSqlConnection())
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
                                BanDo bd = new BanDo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15),
                                    reader.GetString(16), reader.GetString(17), reader.GetString(18));
                                listBD.Add(bd);


                            }


                        }
                    }
                }
            }
            return listBD;



        }
    }
}
