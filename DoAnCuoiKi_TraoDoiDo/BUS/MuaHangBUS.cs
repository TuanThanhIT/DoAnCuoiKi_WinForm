using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class MuaHangBUS
    {
        MuaHangDAO mhd = new MuaHangDAO();
        BUS bus = new BUS();
        public bool ThemMuaHang(MuaHang mh)
        {
            return mhd.ThemMuaHang(mh);
        }
        public string RanDomMaGiaoDich()
        {
            return bus.RandomMa(6);
        }
        public DataTable DSMuaHang()
        {
            return mhd.DSMuaHang();
        }
        public bool XoaLSMuaHang()
        {
            return mhd.xoaLSMuaHang();
        }
    }
}
