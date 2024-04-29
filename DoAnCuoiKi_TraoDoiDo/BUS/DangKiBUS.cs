using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
