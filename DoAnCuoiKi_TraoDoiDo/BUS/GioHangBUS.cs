using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_TraoDoiDo.BUS
{
    public class GioHangBUS
    {
        GioHangDAO ghd = new GioHangDAO();
        public bool ThemGioHang(GioHang gh)
        {
            return ghd.ThemGioHang(gh);
        }
        public bool XoaGioHang(GioHang gh)
        {
            return ghd.XoaGH(gh);
        }
        public bool SuaGioHang(GioHang gh)
        {
            return ghd.SuaGioHang(gh);
        }
        public void SuaGH(GioHang gh)
        {
            ghd.SuaGH(gh);
        }
        public void LoadDanhSach(FlowLayoutPanel fl)
        {
            List<GioHang> ghs = new List<GioHang>();
            ghs = ghd.LoadDanhSach();
            foreach (GioHang j in ghs)
            {
                UCGioHang ucgh = new UCGioHang(j);
                ucgh.Margin = new Padding(0, 0, 0, 8);
                fl.Controls.Add(ucgh);
            }
        }
    }
}
