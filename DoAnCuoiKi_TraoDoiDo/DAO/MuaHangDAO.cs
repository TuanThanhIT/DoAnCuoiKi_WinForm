using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace DoAnCuoiKi_TraoDoiDo.DAO
{
    public class MuaHangDAO
    {
        DBConnection db = new DBConnection();
        DAO d = new DAO();

        public bool ThemMuaHang(MuaHang muaHang) // thêm vào khi mua hàng thành công
        {
            string sqlStr = string.Format("INSERT INTO MuaHàng(Họ_tên, Số_điện_thoại, Địa_chỉ, Ngày_mua_hàng, ID, Tổng_thanh_toán, Mã_giao_dịch)" +
               "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}')", muaHang.Họ_tên, muaHang.Số_điện_thoại, muaHang.Địa_chỉ, muaHang.Ngày_mua_hàng, muaHang.ID, muaHang.Tổng_thanh_toán, muaHang.Mã_giao_dịch);
            return db.Thucthi(sqlStr);
        }
        public DataTable DSMuaHang()  // Lịch sử Mua Hàng, hiển thị lên datagridview
        {
            string sqlStr = string.Format("select [Họ_tên] as [Họ tên], [Số_điện_thoại] as [Số điện thoai], [Địa_chỉ] as [Địa chỉ], [Ngày_mua_hàng] as [Ngày mua hàng], [Tổng_thanh_toán] as [Tổng thanh toán], [Mã_giao_dịch] as [Mã giao dịch]" +
                "from [MuaHàng] where ID = N'{0}'", DangKiDAO.ID);
            return db.Load(sqlStr);
        }
        public DataTable TKMuaHang()  // Thống kê Mua Hàng, hiển thị lên dataridview
        {
            string sqlStr = string.Format("select ID, [Họ_tên] as [Họ tên], [Số_điện_thoại] as [Số điện thoai], [Địa_chỉ] as [Địa chỉ], [Ngày_mua_hàng] as [Ngày mua hàng], [Tổng_thanh_toán] as [Tổng thanh toán], [Mã_giao_dịch] as [Mã giao dịch]" +
                "from [MuaHàng]");
            return db.Load(sqlStr);
        }
        public bool xoaLSMuaHang() // Xóa lịch sử mua hàng
        {
            string sqlStr = string.Format("DELETE FROM [MuaHàng] WHERE [ID] = N'{0}'", DangKiDAO.ID);
            return db.Thucthi(sqlStr);
        }
       
        public List<MuaHang> LoadMuaHang() // Lấy dữ liệu tạo báo cáo lịch sử mua hàng
        {
            string query2 = string.Format("SELECT * FROM [MuaHàng] where [ID] = N'{0}'", DangKiDAO.ID);
            return d.LoadDanhSachMuaHang(query2);  
        }
        public List<MuaHang> LoadTKMuaHang() // Lấy dữ liệu tạo báo cáo thống kê mua hàng
        {
            string query2 = string.Format("SELECT * FROM [MuaHàng] ");
            return d.LoadDanhSachMuaHang(query2);
        }
    }
}
