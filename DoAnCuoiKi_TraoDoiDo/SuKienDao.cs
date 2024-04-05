using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo
{
    public class SuKienDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();

        public void themSuKien(SuKien sk)
        {
            string sqlStr = string.Format("INSERT INTO SựKiện(Tên_sự_kiện, Giảm_giá, Bắt_đầu, Kết_thúc) " + "VALUES ('{0}', '{1}', '{2}', '{3}')", sk.TenSuKien, sk.GiamGia, sk.BatDau, sk.KetThuc);
            db.Thucthi(sqlStr);
        }
        public void xoaSuKien(SuKien sk)
        {

            string sqlStr = string.Format("DELETE FROM SựKiện WHERE Tên_sự_kiện = '{0}'", sk.TenSuKien);
            db.Thucthi(sqlStr);
        }
        public void suaSuKien(SuKien sk)
        {
            string sqlStr = string.Format("UPDATE SựKiện SET Giảm_giá = '{1}', Bắt_đầu = '{2}', Kết_thúc = '{3}'  WHERE Tên_sự_kiện = '{0}'", sk.TenSuKien, sk.GiamGia, sk.BatDau, sk.KetThuc);
            db.Thucthi(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM SựKiện");
            return db.Load(sqlStr);
        }
    }
}
