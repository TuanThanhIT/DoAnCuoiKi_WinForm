using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class DangKiBUS
    {
        public string maQuanTriVien = "TTKH";
        DangKiDAO dkd = new DangKiDAO();
        BUS bus = new BUS();    
        public string RandomMaID()
        {
            return bus.RandomMa(7);
        }
        public bool ThemThanhVien(DangKi dk)
        {
            return dkd.ThemThanhVien(dk);
        }
        public List<DangKi> LoadDSTaiKhoan()
        {
            return dkd.LoadDSDangKi();

        }
        public DataTable DSTaiKhoan()
        {
            return dkd.DSTaiKhoan();
        }
        public List<TaiKhoanReport> layDuLieu() // lấy dữ liệu đưa vào list để làm thống kê
        {
            List<DangKi> listTaiKhoan = LoadDSTaiKhoan();
            List<TaiKhoanReport> listReport = new List<TaiKhoanReport>();
            foreach (DangKi dk in listTaiKhoan)
            {
                TaiKhoanReport temp = new TaiKhoanReport();
                temp.ID = dk.ID;
                temp.Họ_tên = dk.Họ_tên;
                temp.Địa_chỉ = dk.Địa_chỉ;
                temp.Số_điện_thoại = dk.Số_điện_thoại;
                temp.Giới_tính = dk.Giới_tính;
                temp.Ngày_tháng_năm_sinh = dk.Ngày_tháng_năm_sinh;
                temp.Địa_chỉ_Email = dk.Địa_chỉ_Email;
                temp.Ngày_đăng_kí = dk.Ngày_đăng_kí;
                temp.Tên_đăng_nhập = dk.Tên_đăng_nhập;
                temp.Chức_vụ = dk.Chức_vụ;

                listReport.Add(temp);
            }
            return listReport;
        }

    }
}
