using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace DoAnCuoiKi_TraoDoiDo.DAO
{
    public class MuaHangDAO
    {
        DBConnection db = new DBConnection();

        public bool ThemMuaHang(MuaHang muaHang)
        {
            string sqlStr = string.Format("INSERT INTO MuaHàng(Họ_tên_người_mua, Số_điện_thoại, Địa_chỉ, Ngày_mua_hàng, ID, Tổng_thanh_toán, Mã_giao_dịch)" +
               "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}')", muaHang.Hoten, muaHang.Sodt, muaHang.Diachi, muaHang.NgayMuaHang, muaHang.ID, muaHang.TongThanhToan, muaHang.MaGiaoDich);
            return db.Thucthi(sqlStr);
        }
        public DataTable DSMuaHang()
        {
            string sqlStr = string.Format("select [Họ_tên_người_mua] as [Họ tên], [Số_điện_thoại] as [Số điện thoai], [Địa_chỉ] as [Địa chỉ], [Ngày_mua_hàng] as [Ngày mua hàng], [ID] as ID, [Tổng_thanh_toán] as [Tổng thanh toán], [Mã_giao_dịch] as [Mã giao dịch]" +
                "from [MuaHàng] where ID = N'{0}'", DangKiDAO.ID);
            return db.Load(sqlStr);
        }
        public bool xoaLSMuaHang()
        {
            string sqlStr = string.Format("DELETE FROM [MuaHàng] WHERE [ID] = N'{0}'", DangKiDAO.ID);
            return db.Thucthi(sqlStr);
        }
    }
}
