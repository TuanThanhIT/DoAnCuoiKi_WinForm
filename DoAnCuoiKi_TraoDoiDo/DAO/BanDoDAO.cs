using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo.DAO
{
    public class BanDoDAO
    {
       
        DBConnection db = new DBConnection();
        DAO d = new DAO();

        public bool ThemMatHang(BanDo bd)  // Thêm trong FormBanDo
        {

            string sqlStr = string.Format("INSERT INTO ĐăngBán(Tên_mặt_hàng, Loại_mặt_hàng, Giá_bán, Mô_tả_mặt_hàng, Ngày_đăng_bán, Hình_ảnh_1, Hình_ảnh_2, Hình_ảnh_3, Hình_ảnh_4, Mã_Voucher, Giảm_giá, Số_lượng_Voucher, Số_lượng, Địa_điểm, Phương_thức_giao_hàng, Tình_trạng_mặt_hàng, Mã_sản_phẩm, ID, Giá_gốc) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}')", bd.Tên_mặt_hàng, bd.Loại_mặt_hàng, bd.Giá_bán, bd.Mô_tả_mặt_hàng, bd.Ngày_đăng_bán, bd.Hình_ảnh_1, bd.Hình_ảnh_2, bd.Hình_ảnh_3, bd.Hình_ảnh_4,
                bd.Mã_Voucher, bd.Giảm_giá, bd.Số_lượng_Voucher, bd.Số_lượng, bd.Địa_điểm, bd.Phương_thức_giao_hàng, bd.Tình_trạng_mặt_hàng, bd.Mã_sản_phẩm, bd.ID, bd.Giá_gốc);
            return db.Thucthi(sqlStr);


        }

        public void ThemHienThi(BanDo bd)
        {
            string sqlStr = string.Format("INSERT INTO SảnPhẩm(Tên_mặt_hàng, Mã_sản_phẩm, Lượt_xem, Yêu_thích)" +
                "VALUES ('{0}', '{1}', '{2}', '{3}')",bd.Tên_mặt_hàng, bd.Mã_sản_phẩm, bd.Lượt_xem, bd.Yêu_thích);
            db.Thucthi(sqlStr);
        }
        public void SuaHienThi(BanDo bd)
        {
            string sqlStr = string.Format("UPDATE [SảnPhẩm] SET Tên_mặt_hàng = '{0}', Lượt_xem = '{1}', Yêu_thích = '{2}' WHERE Mã_sản_phẩm = '{3}'",
              bd.Tên_mặt_hàng, bd.Lượt_xem, bd.Yêu_thích, bd.Mã_sản_phẩm);
            db.Thucthi(sqlStr);
        }
        public bool XoaMatHang(BanDo bd)  // Xóa trong FormDangBan
        {
            string sqlStr = string.Format("DELETE FROM ĐăngBán WHERE Tên_mặt_hàng = '{0}'", bd.Tên_mặt_hàng);
            return db.Thucthi(sqlStr);
        }
        public bool XoaLSBanHang()// Xóa trong FormLSBanHàng
        {
            string sqlStr = string.Format("DELETE FROM [ĐăngBán] WHERE [ID] = N'{0}' and [Số_lượng] = 0", DangKiDAO.ID);
            return db.Thucthi(sqlStr);
        }
        public bool SuaMatHang(BanDo bd) // Sửa trrong FormDangBan, sửa theo tên
        {
            string sqlStr = string.Format("UPDATE [ĐăngBán] SET  [Loại_mặt_hàng] = '{0}', [Giá_bán] = '{1}', [Mô_tả_mặt_hàng] = '{2}', [Hình_ảnh_1] = '{3}', [Hình_ảnh_2] = '{4}', [Hình_ảnh_3] = '{5}', [Hình_ảnh_4] = '{6}', [Mã_Voucher] = '{7}', [Giảm_giá] = '{8}', [Số_lượng_Voucher] = '{9}', [Số_lượng] = '{10}', [Địa_điểm] = '{11}', [Phương_thức_giao_hàng] = '{12}', [Tình_trạng_mặt_hàng] = '{13}', [Mã_sản_phẩm] = '{14}', [Ngày_đăng_bán] = '{15}', [ID] = '{16}', [Giá_gốc] = '{17}' where [Tên_mặt_hàng] = '{18}'",
                bd.Loại_mặt_hàng, bd.Giá_bán, bd.Mô_tả_mặt_hàng, bd.Hình_ảnh_1, bd.Hình_ảnh_2, bd.Hình_ảnh_3, bd.Hình_ảnh_4, bd.Mã_Voucher, bd.Giảm_giá, bd.Số_lượng_Voucher, bd.Số_lượng, bd.Địa_điểm, bd.Phương_thức_giao_hàng, bd.Tình_trạng_mặt_hàng, bd.Mã_sản_phẩm, bd.Ngày_đăng_bán, bd.ID, bd.Giá_gốc, bd.Tên_mặt_hàng);
            return db.Thucthi(sqlStr);
        }
        public void SuaMatHang1(BanDo bd) //Thay đổi số lượng Voucher khi áp mã thành công và khi mua hàng thành công
        {
            string sqlStr = string.Format("UPDATE [ĐăngBán] SET Số_lượng_Voucher = '{0}', Số_lượng = '{1}' WHERE Mã_sản_phẩm = '{2}'",
                bd.Số_lượng_Voucher, bd.Số_lượng, bd.Mã_sản_phẩm);
            db.Thucthi(sqlStr);
        }
       
        public DataTable DanhSachDangBan()  // Lấy dữ liệu để hiển thị trong datagridview trong FormDangBan, những mặt hàng có số lượng khác 0
        {
            string sqlStr = string.Format("select [Tên_mặt_hàng] as [Tên sản phẩm], [Loại_mặt_hàng] as [Loại sản phẩm], [Giá_bán] as [Giá bán], [Mô_tả_mặt_hàng] as [Mô tả],  [Hình_ảnh_1] as [Đường dẫn ảnh], [Hình_ảnh_2] as [Đường dẫn ảnh 2], [Hình_ảnh_3] as [Đường dẫn ảnh 3], [Hình_ảnh_4] as [Đường dẫn ảnh 4], [Mã_Voucher] as [Mã Voucher], [Giảm_giá] as [Giảm giá (%)], [Số_lượng_Voucher] as [Số lượng Voucher], [Số_lượng] as [Số lượng còn lại], [Địa_điểm] as [Địa điểm], [Phương_thức_giao_hàng] as [Phương thức giao hàng], [Tình_trạng_mặt_hàng] as [Tình trạng sản phẩm], Mã_sản_phẩm as [Mã sản phẩm],[Ngày_đăng_bán] as [Ngày đăng bán], ID, Giá_gốc as [Giá gốc]" +
                "from [ĐăngBán] where [Số_lượng] > 0 and ID = N'{0}'", DangKiDAO.ID);
            return db.Load(sqlStr);
        }
        public DataTable DanhSachLSBanDo() // lấy dữ liệu hiển thị datagridview trong FormLSBanHang, những mặt hàng của mình đã bán hết
        {
            string sqlStr = string.Format("select [Tên_mặt_hàng] as [Tên sản phẩm], [Loại_mặt_hàng] as [Loại sản phẩm], [Giá_bán] as [Giá bán], [Mô_tả_mặt_hàng] as [Mô tả sản phẩm],  [Mã_Voucher] as [Mã Voucher], [Giảm_giá] as [Giảm giá (%)], [Số_lượng_Voucher] as [Số lượng Voucher], [Địa_điểm] as [Địa điểm], [Phương_thức_giao_hàng] as [Phương thức giao hàng], [Tình_trạng_mặt_hàng] as [Tình trạng sản phẩm], Mã_sản_phẩm as [Mã sản phẩm],[Ngày_đăng_bán] as [Ngày đăng bán], Giá_gốc as [Giá gốc]" +
                "from [ĐăngBán] where [Số_lượng] = 0 and ID = N'{0}'", DangKiDAO.ID);
            return db.Load(sqlStr);
        }
        public DataTable DanhSachTKBanDo()  // Lấy dữ liệu để hiển thị lên datagridview FormTKBanHang, hiển thị tất cả giao dịch bán hàng
        {
            string sqlStr = string.Format("select ID, [Tên_mặt_hàng] as [Tên sản phẩm], [Loại_mặt_hàng] as [Loại sản phẩm], [Giá_bán] as [Giá bán], [Mô_tả_mặt_hàng] as [Mô tả sản phẩm],  [Mã_Voucher] as [Mã Voucher], [Giảm_giá] as [Giảm giá (%)], [Số_lượng_Voucher] as [Số lượng Voucher], [Số_lượng] as [Số lượng còn lại], [Địa_điểm] as [Địa điểm], [Phương_thức_giao_hàng] as [Phương thức giao hàng], [Tình_trạng_mặt_hàng] as [Tình trạng sản phẩm], Mã_sản_phẩm as [Mã sản phẩm],[Ngày_đăng_bán] as [Ngày đăng bán], Giá_gốc as [Giá gốc]" +
                "from [ĐăngBán]");
            return db.Load(sqlStr);
        }


        public List<BanDo> LoadDanhSach() // Lấy dữ liệu để hiển thị UCHienThi
        {
            string query2 = "SELECT dangban.Tên_mặt_hàng, Loại_mặt_hàng, Giá_bán, Mô_tả_mặt_hàng, Hình_ảnh_1, Hình_ảnh_2, Hình_ảnh_3, Hình_ảnh_4, Mã_Voucher, Giảm_giá, Số_lượng_Voucher, Số_lượng, Địa_điểm, Phương_thức_giao_hàng, Tình_trạng_mặt_hàng, dangban.Mã_sản_phẩm, Ngày_đăng_bán, ID, Giá_gốc, Lượt_xem, Yêu_thích " +
               "FROM [ĐăngBán] AS dangban INNER JOIN [SảnPhẩm] AS sanpham ON dangban.Mã_sản_phẩm = sanpham.Mã_sản_phẩm " +
               "WHERE dangban.Số_lượng > 0";
            return d.LoadDanhSachDangBan2(query2);
        }
        public List<BanDo> LoadDSVou() // Lấy dữ liệu để hiển thị UCVoucher
        {
            string query2 = string.Format("SELECT * FROM [ĐăngBán] WHERE [Số_lượng_Voucher] > 0 and Số_lượng >0");
            return d.LoadDanhSachDangBan(query2);
        }
        public List<BanDo> LoadBaoCaoBanHang() // Lấy dữ liệu để tạo báo cáo trong lịch sử bán hàng
        {
            string sqlStr = string.Format("select *" +
                "from [ĐăngBán] where [Số_lượng] = 0 and ID = N'{0}'", DangKiDAO.ID);
            return d.LoadDanhSachDangBan(sqlStr);
        }
        public List<BanDo> LoadTKBanHang() // Lấy dữ liệu tạo thống kê bán hàng
        {
            string sqlStr = string.Format("select *" +
                "from [ĐăngBán]");
            return d.LoadDanhSachDangBan(sqlStr);
        }
    }
}
