using DoAnCuoiKi_TraoDoiDo.DAO;
using DoAnCuoiKi_TraoDoiDo.DTO;
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
        public void LoadDanhSach(FlowLayoutPanel fl, TextBox tk)
        {
            List<GioHang> ghs = new List<GioHang>();
            ghs = ghd.LoadDanhSach();
            fl.Controls.Clear(); // Xóa các controls cũ trên flow layout
            string tuKhoa = tk.Text.ToLower();
            
            foreach (GioHang j in ghs)
            {

                string tenMatHang = j.Tên_mặt_hàng.ToLower();
                if (string.IsNullOrEmpty(tuKhoa) || tenMatHang.Contains(tuKhoa))
                {
                    UCGioHang ucgh = new UCGioHang(j);
                    ucgh.Margin = new Padding(0, 0, 0, 8);
                    fl.Controls.Add(ucgh);
                }
               
            }
        }
    }
}
